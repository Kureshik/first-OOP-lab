using System.Diagnostics;
using System.Text.Json;
using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

namespace Study.LabWork2.Feature.Task2;

/// <summary>
/// Асинхронная версия приложения (с использованием async/await)
/// </summary>
public sealed class AsynchronousServerRequestApp : IServerRequestApp
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        WriteIndented = true
    };

    private readonly IRequestService _requestService;

    /// <summary>
    /// Создает экземпляр асинхронного приложения для выполнения запросов к серверам.
    /// </summary>
    /// <param name="requestService">
    /// Сервис отправки запросов. Если не передан, используется <see cref="HttpRequestService"/>.
    /// </param>
    public AsynchronousServerRequestApp(IRequestService requestService = null)
    {
        _requestService = requestService ?? new HttpRequestService();
    }

    /// <summary>
    /// Выполняет запросы к серверам и возвращает агрегированный результат.
    /// </summary>
    /// <typeparam name="TResponse">Тип модели для десериализации JSON-ответов.</typeparam>
    /// <param name="servers">Массив серверов для опроса.</param>
    /// <returns>Результат выполнения запросов.</returns>
    public ExecutionResultDto<TResponse> ExecuteRequests<TResponse>(ServerConfigDto[] servers)
    {
        return ExecuteRequestsAsync<TResponse>(servers).GetAwaiter().GetResult();
    }

    /// <summary>
    /// Возвращает название версии приложения.
    /// </summary>
    /// <returns>Строка с названием версии.</returns>
    public string GetVersion() => "Asynchronous";

    /// <summary>
    /// Асинхронное выполнение запросов
    /// </summary>
    private async Task<ExecutionResultDto<TResponse>> ExecuteRequestsAsync<TResponse>(ServerConfigDto[] servers)
    {
        ArgumentNullException.ThrowIfNull(servers);
        if (servers.Length == 0)
        {
            throw new ArgumentException("Список серверов не должен быть пустым.", nameof(servers));
        }

        foreach (var server in servers)
        {
            EnsureServerConfigValid(server);
        }

        var cts = new CancellationTokenSource();
        var stopwatch = Stopwatch.StartNew();

        try
        {
            var requestTasks = servers.Select((server, index) => FetchResponseAsync<TResponse>(server, index, cts.Token)).ToArray();
            var completedResponses = await Task.WhenAll(requestTasks);

            foreach (var (_, response) in completedResponses.OrderBy(x => x.Index))
            {
                Console.WriteLine(JsonSerializer.Serialize(response, JsonOptions));
            }

            return new ExecutionResultDto<TResponse>
            {
                Responses = completedResponses.OrderBy(x => x.Index).Select(x => x.Response).ToList(),
                SuccessfulRequests = completedResponses.Length,
                FailedRequests = 0,
                TotalExecutionTime = stopwatch.Elapsed,
                Version = GetVersion()
            };
        }
        catch (Exception ex) when (ex is not InvalidOperationException)
        {
            Console.WriteLine($"Ошибка выполнения запросов: {ex.Message}");
            throw;
        }
        finally
        {
            cts.Cancel();
            stopwatch.Stop();
            Console.WriteLine($"Общее время выполнения: {stopwatch.Elapsed.TotalMilliseconds:F2} мс");
        }
    }

    /// <summary>
    /// Асинхронно выполняет запрос к серверу, возвращает индекс и десериализованный ответ.
    /// </summary>
    /// <typeparam name="TResponse">Тип модели для десериализации JSON-ответа.</typeparam>
    /// <param name="server">Конфигурация сервера.</param>
    /// <param name="index">Индекс сервера в массиве.</param>
    /// <param name="cancellationToken">Токен отмены.</param>
    /// <returns>Кортеж с индексом и десериализованным ответом.</returns>
    private async Task<(int Index, TResponse Response)> FetchResponseAsync<TResponse>(
        ServerConfigDto server,
        int index,
        CancellationToken cancellationToken)
    {
        var responseJson = await _requestService.FetchDataAsync(server.Url, cancellationToken);
        EnsurePositiveResponse(server, responseJson);
        var response = DeserializeResponse<TResponse>(responseJson, server);
        return (index, response);
    }

    /// <summary>
    /// Проверяет валидность конфигурации сервера. Если конфигурация невалидна, выбрасывает исключение.
    /// </summary>
    /// <param name="server">Конфигурация сервера.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если конфигурация сервера невалидна.</exception>
    private static void EnsureServerConfigValid(ServerConfigDto server)
    {
        if (server is null || !server.IsValid())
        {
            throw new ArgumentException("Обнаружена невалидная конфигурация сервера.");
        }
    }

    /// <summary>
    /// Проверяет JSON-ответ от сервера на наличие признаков отрицательного ответа. Если ответ считается отрицательным, выбрасывает исключение.
    /// </summary>
    /// <param name="server">Конфигурация сервера.</param>
    /// <param name="responseJson">JSON-ответ от сервера.</param>
    /// <exception cref="InvalidOperationException">Выбрасывается, если ответ считается отрицательным.</exception>
    private static void EnsurePositiveResponse(ServerConfigDto server, string responseJson)
    {
        if (!IsPositiveResponse(responseJson))
        {
            var errorMessage = $"Сервер '{server.Name}' вернул отрицательный ответ. Выполнение остановлено.";
            Console.WriteLine(errorMessage);
            throw new InvalidOperationException(errorMessage);
        }
    }

    /// <summary>
    /// Десериализует JSON-ответ от сервера в объект типа TResponse. Если десериализация не удалась, выбрасывает исключение с подробным сообщением.
    /// </summary>
    /// <typeparam name="TResponse">Тип модели для десериализации JSON-ответа.</typeparam>
    /// <param name="responseJson">JSON-ответ от сервера.</param>
    /// <param name="server">Конфигурация сервера.</param>
    /// <returns>Десериализованный объект типа TResponse.</returns>
    /// <exception cref="InvalidOperationException">Выбрасывается, если десериализация не удалась.</exception>
    private static TResponse DeserializeResponse<TResponse>(string responseJson, ServerConfigDto server)
    {
        try
        {
            var response = JsonSerializer.Deserialize<TResponse>(responseJson, JsonOptions);
            if (response is null)
            {
                throw new InvalidOperationException($"Пустой JSON-ответ от сервера '{server.Name}'.");
            }

            return response;
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException(
                $"Некорректный JSON от сервера '{server.Name}'. Подробности: {ex.Message}",
                ex);
        }
    }

    /// <summary>
    /// Проверяет JSON-ответ от сервера на наличие признаков положительного ответа. Если JSON не является объектом или не содержит явных признаков отрицательного ответа, считается положительным.
    /// </summary>
    /// <param name="json">JSON-ответ от сервера.</param>
    /// <returns><see langword="true"/>, если ответ считается положительным; иначе <see langword="false"/>.</returns>
    private static bool IsPositiveResponse(string json)
    {
        try
        {
            using var document = JsonDocument.Parse(json);
            var root = document.RootElement;
            if (root.ValueKind != JsonValueKind.Object)
            {
                return true;
            }

            if (TryGetBoolean(root, "success", out var success))
            {
                return success;
            }

            if (TryGetBoolean(root, "ok", out var ok))
            {
                return ok;
            }

            if (TryGetBoolean(root, "isSuccess", out var isSuccess))
            {
                return isSuccess;
            }

            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }

    /// <summary>
    /// Пытается извлечь булевое значение из JSON-объекта по заданному имени свойства. Учитывает, что булевое значение может быть представлено как true/false в JSON. Если свойство найдено и является булевым, возвращает его значение через выходной параметр и <see langword="true"/>; иначе возвращает <see langword="false"/> и устанавливает выходной параметр в <see langword="false"/>.
    /// </summary>
    /// <param name="root">JSON-объект для проверки.</param>
    /// <param name="propertyName">Имя свойства для извлечения.</param>
    /// <param name="value">Выходной параметр для хранения извлеченного значения.</param>
    /// <returns><see langword="true"/>, если свойство найдено и является булевым; иначе <see langword="false"/>.</returns>
    private static bool TryGetBoolean(JsonElement root, string propertyName, out bool value)
    {
        if (root.TryGetProperty(propertyName, out var property) && property.ValueKind == JsonValueKind.True)
        {
            value = true;
            return true;
        }

        if (root.TryGetProperty(propertyName, out property) && property.ValueKind == JsonValueKind.False)
        {
            value = false;
            return true;
        }

        value = false;
        return false;
    }
}
