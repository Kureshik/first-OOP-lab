using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;
using Study.LabWork2.Feature.Task2;

namespace Study.LabWork2.UnitTests.Feature.Task2;

/// <summary>
/// Тесты для <see cref="AsynchronousServerRequestApp"/>.
/// </summary>
[TestFixture]
public sealed class AsynchronousServerRequestAppTests
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
    /// Проверяет, что версия асинхронного приложения возвращается корректно.
    /// </summary>
    [Test]
    public void GetVersion_ReturnsAsynchronous()
    {
        var app = new AsynchronousServerRequestApp(new FakeRequestService());

        Assert.That(app.GetVersion(), Is.EqualTo("Asynchronous"));
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

        var app = new AsynchronousServerRequestApp(fakeService);
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
    /// Проверяет выброс исключения при отрицательном ответе одного из серверов.
    /// </summary>
    [Test]
    public void ExecuteRequests_Throws_WhenServerReturnsNegativeResponse()
    {
        var fakeService = new FakeRequestService(new Dictionary<string, string>
        {
            ["https://server-1.test/api"] = """{"success":true,"name":"server-1"}""",
            ["https://server-2.test/api"] = """{"success":false,"name":"server-2"}""",
            ["https://server-3.test/api"] = """{"success":true,"name":"server-3"}"""
        });

        var app = new AsynchronousServerRequestApp(fakeService);
        var servers = CreateThreeServers();

        using var output = new StringWriter();
        Console.SetOut(output);

        var ex = Assert.Throws<InvalidOperationException>(() => app.ExecuteRequests<ServerResponseDto>(servers));
        var consoleOutput = output.ToString();

        Assert.Multiple(() =>
        {
            Assert.That(ex!.Message, Does.Contain("отрицательный ответ"));
            Assert.That(consoleOutput, Does.Contain("вернул отрицательный ответ"));
            Assert.That(fakeService.AsyncCalls.Count, Is.GreaterThan(0));
        });
    }

    /// <summary>
    /// Проверяет выброс <see cref="ArgumentException"/> при невалидной конфигурации серверов.
    /// </summary>
    [Test]
    public void ExecuteRequests_ThrowsArgumentException_WhenServersInvalid()
    {
        var app = new AsynchronousServerRequestApp(new FakeRequestService());

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

        public List<string> AsyncCalls { get; } = [];

        public string FetchData(string url)
        {
            throw new NotSupportedException();
        }

        public Task<string> FetchDataAsync(string url, CancellationToken cancellationToken = default)
        {
            AsyncCalls.Add(url);
            return Task.FromResult(_responsesByUrl[url]);
        }
    }
}
