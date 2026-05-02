using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;
using Study.LabWork2.Feature.Task2;

namespace Study.LabWork2.UnitTests.Feature.Task2;

/// <summary>
/// Тесты для <see cref="SynchronousServerRequestApp"/>.
/// </summary>
[TestFixture]
public sealed class SynchronousServerRequestAppTests
{
    private TextWriter _originalOut = null!;

    /// <summary>
    /// Сохраняет исходный поток вывода консоли перед каждым тестом.
    /// </summary>
    [SetUp]
    public void SetUp()
    {
        _originalOut = Console.Out;
    }

    /// <summary>
    /// Восстанавливает исходный поток вывода консоли после каждого теста.
    /// </summary>
    [TearDown]
    public void TearDown()
    {
        Console.SetOut(_originalOut);
    }

    /// <summary>
    /// Проверяет, что версия синхронного приложения возвращается корректно.
    /// </summary>
    [Test]
    public void GetVersion_ReturnsSynchronous()
    {
        var app = new SynchronousServerRequestApp(new FakeRequestService());

        Assert.That(app.GetVersion(), Is.EqualTo("Synchronous"));
    }

    /// <summary>
    /// Проверяет обработку трех серверов, JSON-вывод ответов и вывод общего времени выполнения.
    /// </summary>
    [Test]
    public void ExecuteRequests_ProcessesThreeServers_AndPrintsJsonAndTotalTime()
    {
        var fakeService = new FakeRequestService(new Dictionary<string, string>
        {
            ["https://server-1.test/api"] = """{"success":true,"name":"server-1"}""",
            ["https://server-2.test/api"] = """{"success":true,"name":"server-2"}""",
            ["https://server-3.test/api"] = """{"success":true,"name":"server-3"}"""
        });

        var app = new SynchronousServerRequestApp(fakeService);
        var servers = CreateThreeServers();

        using var output = new StringWriter();
        Console.SetOut(output);

        var result = app.ExecuteRequests<ServerResponseDto>(servers);
        var consoleOutput = output.ToString();

        Assert.Multiple(() =>
        {
            Assert.That(result.Responses, Has.Count.EqualTo(3));
            Assert.That(result.SuccessfulRequests, Is.EqualTo(3));
            Assert.That(result.FailedRequests, Is.EqualTo(0));
            Assert.That(result.TotalExecutionTime, Is.GreaterThan(TimeSpan.Zero));
            Assert.That(consoleOutput, Does.Contain("\"Name\": \"server-1\""));
            Assert.That(consoleOutput, Does.Contain("\"Name\": \"server-2\""));
            Assert.That(consoleOutput, Does.Contain("\"Name\": \"server-3\""));
            Assert.That(consoleOutput, Does.Contain("Общее время выполнения:"));
        });
    }

    /// <summary>
    /// Проверяет остановку выполнения и выброс исключения при отрицательном ответе сервера.
    /// </summary>
    [Test]
    public void ExecuteRequests_ThrowsAndStops_WhenServerReturnsNegativeResponse()
    {
        var fakeService = new FakeRequestService(new Dictionary<string, string>
        {
            ["https://server-1.test/api"] = """{"success":true,"name":"server-1"}""",
            ["https://server-2.test/api"] = """{"success":false,"name":"server-2"}""",
            ["https://server-3.test/api"] = """{"success":true,"name":"server-3"}"""
        });

        var app = new SynchronousServerRequestApp(fakeService);
        var servers = CreateThreeServers();

        using var output = new StringWriter();
        Console.SetOut(output);

        var ex = Assert.Throws<InvalidOperationException>(() => app.ExecuteRequests<ServerResponseDto>(servers));
        var consoleOutput = output.ToString();

        Assert.Multiple(() =>
        {
            Assert.That(ex!.Message, Does.Contain("отрицательный ответ"));
            Assert.That(consoleOutput, Does.Contain("Сервер 'Server-2' вернул отрицательный ответ"));
            Assert.That(fakeService.SyncCalls, Has.Count.EqualTo(2), "после негативного ответа следующие запросы не должны выполняться");
        });
    }

    /// <summary>
    /// Проверяет выброс <see cref="ArgumentException"/> при невалидной конфигурации серверов.
    /// </summary>
    [Test]
    public void ExecuteRequests_ThrowsArgumentException_WhenServersInvalid()
    {
        var app = new SynchronousServerRequestApp(new FakeRequestService());

        var invalidServers = new[]
        {
            new ServerConfigDto
            {
                Name = "",
                Url = "not-url",
                Method = "GET",
                TimeoutSeconds = 10
            }
        };

        Assert.Throws<ArgumentException>(() => app.ExecuteRequests<ServerResponseDto>(invalidServers));
    }

    private static ServerConfigDto[] CreateThreeServers()
    {
        return
        [
            new ServerConfigDto { Name = "Server-1", Url = "https://server-1.test/api", Method = "GET", TimeoutSeconds = 10 },
            new ServerConfigDto { Name = "Server-2", Url = "https://server-2.test/api", Method = "GET", TimeoutSeconds = 10 },
            new ServerConfigDto { Name = "Server-3", Url = "https://server-3.test/api", Method = "GET", TimeoutSeconds = 10 }
        ];
    }

    private sealed class ServerResponseDto
    {
        public bool Success { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    private sealed class FakeRequestService : IRequestService
    {
        private readonly Dictionary<string, string> _responsesByUrl;

        public FakeRequestService(Dictionary<string, string> responsesByUrl = null)
        {
            _responsesByUrl = responsesByUrl ?? new Dictionary<string, string>();
        }

        public List<string> SyncCalls { get; } = [];

        public string FetchData(string url)
        {
            SyncCalls.Add(url);
            return _responsesByUrl[url];
        }

        public Task<string> FetchDataAsync(string url, CancellationToken cancellationToken = default)
        {
            throw new NotSupportedException();
        }
    }
}
