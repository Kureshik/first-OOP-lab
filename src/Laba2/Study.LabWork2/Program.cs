using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;
using Study.LabWork2.Feature.Task2;

namespace Study.LabWork2;

/// <summary>
/// Точка входа приложения и демонстрация запуска Task2 в двух версиях.
/// </summary>
public static class Program
{
    /// <summary>
    /// Запускает синхронную и асинхронную версии Task2 для трех серверов.
    /// </summary>
    public static void Main()
    {
        var servers = new[]
        {
            new ServerConfigDto { Name = "Server-1", Url = "https://server-1.local/api", Method = "GET", TimeoutSeconds = 15 },
            new ServerConfigDto { Name = "Server-2", Url = "https://server-2.local/api", Method = "GET", TimeoutSeconds = 15 },
            new ServerConfigDto { Name = "Server-3", Url = "https://server-3.local/api", Method = "GET", TimeoutSeconds = 15 }
        };

        IRequestService mockRequestService = new DemoRequestService(new Dictionary<string, string>
        {
            ["https://server-1.local/api"] = """{"success":true,"server":"Server-1","value":101}""",
            ["https://server-2.local/api"] = """{"success":true,"server":"Server-2","value":202}""",
            ["https://server-3.local/api"] = """{"success":false,"server":"Server-3","value":303}"""
        });

        RunTask2Version(new SynchronousServerRequestApp(mockRequestService), servers);
        Console.WriteLine();
        RunTask2Version(new AsynchronousServerRequestApp(mockRequestService), servers);
    }

    /// <summary>
    /// Выполняет запросы к серверам с помощью указанного приложения и выводит результаты.
    /// </summary>
    /// <param name="app">Приложение для выполнения запросов.</param>
    /// <param name="servers">Массив серверов для опроса.</param>
    private static void RunTask2Version(IServerRequestApp app, ServerConfigDto[] servers)
    {
        Console.WriteLine($"=== Task2: {app.GetVersion()} ===");

        try
        {
            var result = app.ExecuteRequests<object>(servers);
            Console.WriteLine($"Успешных запросов: {result.SuccessfulRequests}");
            Console.WriteLine($"Неудачных запросов: {result.FailedRequests}");
            Console.WriteLine($"Время выполнения (DTO): {result.TotalExecutionTime.TotalMilliseconds:F2} мс");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
        }
    }

    /// <summary>
    /// Простая реализация IRequestService для демонстрационных целей, возвращающая предопределенные ответы на запросы.
    /// </summary>
    /// <param name="responses">Словарь, где ключом является URL сервера, а значением - предопределенный ответ.</param>
    private sealed class DemoRequestService(Dictionary<string, string> responses) : IRequestService
    {
        public string FetchData(string url)
        {
            if (!responses.TryGetValue(url, out var response))
            {
                throw new InvalidOperationException($"Mock-ответ для '{url}' не найден.");
            }

            return response;
        }

        public Task<string> FetchDataAsync(string url, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(FetchData(url));
        }
    }
}
