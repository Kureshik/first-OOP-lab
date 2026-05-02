using System.Diagnostics;
using System.Text.Json;
using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

namespace Study.LabWork2.Feature.Task2;

/// <summary>
/// Синхронная версия приложения (без использования async/await)
/// </summary>
public sealed class SynchronousServerRequestApp : IServerRequestApp
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        WriteIndented = true
    };

    private readonly IRequestService _requestService;

    /// <summary>
    /// Создает экземпляр синхронного приложения для выполнения запросов к серверам.
    /// </summary>
    /// <param name="requestService">
    /// Сервис отправки запросов. Если не передан, используется <see cref="HttpRequestService"/>.
    /// </param>
    public SynchronousServerRequestApp(IRequestService requestService = null)
    {
        _requestService = requestService ?? new HttpRequestService();
    }

    /// <summary>
    /// Выполняет запросы к серверам последовательно и возвращает агрегированный результат.
    /// </summary>
    /// <typeparam name="TResponse">Тип модели для десериализации JSON-ответов.</typeparam>
    /// <param name="servers">Массив серверов для опроса.</param>
    /// <returns>Результат выполнения запросов.</returns>
    public ExecutionResultDto<TResponse> ExecuteRequests<TResponse>(ServerConfigDto[] servers)
    {
        ArgumentNullException.ThrowIfNull(servers);
        if (servers.Length == 0)
        {
            throw new ArgumentException("Список серверов не должен быть пустым.", nameof(servers));
        }

        var stopwatch = Stopwatch.StartNew();
        var responses = new List<TResponse>(servers.Length);

        try
        {
            foreach (var server in servers)
            {
                EnsureServerConfigValid(server);
                var responseJson = _requestService.FetchData(server.Url);
                EnsurePositiveResponse(server, responseJson);

                var response = DeserializeResponse<TResponse>(responseJson, server);
                responses.Add(response);

                Console.WriteLine(JsonSerializer.Serialize(response, JsonOptions));
            }
        }
        catch (Exception ex) when (ex is not InvalidOperationException)
        {
            Console.WriteLine($"Ошибка выполнения запросов: {ex.Message}");
            throw;
        }
        finally
        {
            stopwatch.Stop();
            Console.WriteLine($"Общее время выполнения: {stopwatch.Elapsed.TotalMilliseconds:F2} мс");
        }

        return new ExecutionResultDto<TResponse>
        {
            Responses = responses,
            SuccessfulRequests = responses.Count,
            FailedRequests = 0,
            TotalExecutionTime = stopwatch.Elapsed,
            Version = GetVersion()
        };
    }

    /// <summary>
    /// Возвращает название версии приложения.
    /// </summary>
    /// <returns>Строка с названием версии.</returns>
    public string GetVersion() => "Synchronous";

    /// <summary>
    /// Проверяет валидность конфигурации сервера. Если конфигурация невалидна, выбрасывает исключение.
    /// </summary>
    /// <param name="server">Конфигурация сервера для проверки.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если конфигурация сервера невалидна.</exception>
    private static void EnsureServerConfigValid(ServerConfigDto server)
    {
        if (server is null || !server.IsValid())
        {
            throw new ArgumentException("Обнаружена невалидная конфигурация сервера.");
        }
    }

    /// <summary>
    /// Проверяет JSON-ответ от сервера на наличие признаков успешного выполнения. Если ответ указывает на ошибку, выбрасывает исключение.
    /// </summary>
    /// <param name="server">Конфигурация сервера, от которого получен ответ.</param>
    /// <param name="responseJson">JSON-ответ от сервера.</param>
    /// <exception cref="InvalidOperationException">Выбрасывается, если ответ указывает на ошибку.</exception>
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
    /// Пытается десериализовать JSON-ответ от сервера в объект указанного типа. Если десериализация не удалась, выбрасывает исключение с подробным сообщением.
    /// </summary>
    /// <typeparam name="TResponse">Тип модели для десериализации JSON-ответа.</typeparam>
    /// <param name="responseJson">JSON-ответ от сервера.</param>
    /// <param name="server">Конфигурация сервера, от которого получен ответ.</param>
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
    /// Пытается извлечь логическое значение из JSON-объекта по указанному имени свойства. Учитывает, что свойство может быть представлено как true/false или как строка "true"/"false". Если извлечение прошло успешно, возвращает <see langword="true"/> и устанавливает значение; иначе возвращает <see langword="false"/> и устанавливает значение в <see langword="false"/>.
    /// </summary>
    /// <param name="root">JSON-объект для извлечения значения.</param>
    /// <param name="propertyName">Имя свойства для извлечения.</param>
    /// <param name="value">Извлеченное логическое значение.</param>
    /// <returns><see langword="true"/>, если извлечение прошло успешно; иначе <see langword="false"/>.</returns>
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
