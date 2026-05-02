using Study.LabWork2.Abstractions.Feature.Task2;

namespace Study.LabWork2.Feature.Task2;

/// <summary>
/// Реализация сервиса HTTP-запросов для Task2.
/// </summary>
public sealed class HttpRequestService : IRequestService
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Создает сервис HTTP-запросов.
    /// </summary>
    /// <param name="httpClient">
    /// Экземпляр <see cref="HttpClient"/>. Если не передан, создается новый.
    /// </param>
    public HttpRequestService(HttpClient httpClient = null)
    {
        _httpClient = httpClient ?? new HttpClient();
    }

    /// <summary>
    /// Выполняет синхронный запрос данных по указанному URL.
    /// </summary>
    /// <param name="url">Адрес сервиса.</param>
    /// <returns>Строка с ответом сервера.</returns>
    public string FetchData(string url)
    {
        return _httpClient.GetStringAsync(url).GetAwaiter().GetResult();
    }

    /// <summary>
    /// Выполняет асинхронный запрос данных по указанному URL.
    /// </summary>
    /// <param name="url">Адрес сервиса.</param>
    /// <param name="cancellationToken">Токен отмены операции.</param>
    /// <returns>Задача с ответом сервера в виде строки.</returns>
    public Task<string> FetchDataAsync(string url, CancellationToken cancellationToken = default)
    {
        return _httpClient.GetStringAsync(url, cancellationToken);
    }
}
