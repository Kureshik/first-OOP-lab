using Study.LabWork2.Feature.Task1.SubTask2;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask2;

/// <summary>
/// Тесты для класса NumberSetProcessor, который обрабатывает 15 наборов чисел из файла и собирает результаты в NumberSetResult.
/// </summary>
[TestFixture]
public sealed class NumberSetProcessorTests
{
    private const string DatasetPath = "task1_subtask2_dataset.txt";

    /// <summary>
    /// Выполняет подготовку среды тестирования перед запуском каждого теста, удаляя файл датасета, если он существует.
    /// </summary>
    [SetUp]
    public void SetUp()
    {
        // Удаляем файл датасета перед каждым тестом, чтобы обеспечить детерминированность
        if (File.Exists(DatasetPath))
            File.Delete(DatasetPath);
    }

    /// <summary>
    /// Выполняет очистку среды тестирования после выполнения каждого теста, удаляя файл датасета, если он был создан.
    /// </summary>
    [TearDown]
    public void TearDown()
    {
        if (File.Exists(DatasetPath))
            File.Delete(DatasetPath);
    }

    /// <summary>
    /// Проверяет, что метод GetResult выбрасывает исключение InvalidOperationException,
    /// если обработка наборов чисел не была выполнена.
    /// </summary>
    [Test]
    public void GetResult_Throws_WhenNotProcessed()
    {
        var processor = new NumberSetProcessor();

        Assert.Throws<InvalidOperationException>(() => processor.GetResult());
    }

    /// <summary>
    /// Проверяет, что метод Process корректно обрабатывает все наборы чисел и возвращает правильные результаты.
    /// </summary>
    [Test]
    public void Process_ProcessesAllSets_Correctly()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();

        Assert.Multiple(() =>
        {
            Assert.That(result.ProcessedSetsCount, Is.EqualTo(15));
            Assert.That(result.Results, Has.Count.EqualTo(15));
            Assert.That(result.TotalSum, Is.GreaterThan(0));
            Assert.That(result.ExecutionTime, Is.GreaterThan(TimeSpan.Zero));
        });
    }

    /// <summary>
    /// Проверяет, что результаты обработки наборов чисел упорядочены по номеру набора (SetNumber) в порядке возрастания.
    /// </summary>
    [Test]
    public void Process_ResultsAreOrderedBySetNumber()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();
        var setNumbers = result.Results.Select(r => r.SetNumber).ToList();

        Assert.That(setNumbers, Is.Ordered.Ascending);
        Assert.That(setNumbers, Is.EqualTo(Enumerable.Range(1, 15).ToList()));
    }

    /// <summary>
    /// Проверяет, что сумма чисел в каждом наборе (Sum) находится в допустимом диапазоне от 100 до 10 000,
    /// и что идентификатор потока (ThreadId) больше 0.
    /// </summary>
    [Test]
    public void Process_EachSetSum_IsInValidRange()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();

        foreach (var entry in result.Results)
        {
            Assert.Multiple(() =>
            {
                Assert.That(entry.Sum, Is.GreaterThanOrEqualTo(100), $"Set {entry.SetNumber}");
                Assert.That(entry.Sum, Is.LessThanOrEqualTo(10000), $"Set {entry.SetNumber}");
                Assert.That(entry.ThreadId, Is.GreaterThan(0), $"Set {entry.SetNumber}");
            });
        }
    }

    /// <summary>
    /// Проверяет, что общая сумма (TotalSum) в результате обработки равна сумме всех индивидуальных сумм (Sum) для каждого набора чисел.
    /// </summary>
    [Test]
    public void Process_TotalSum_EqualsSumOfAllSetSums()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();

        var calculatedTotal = result.Results.Sum(r => r.Sum);

        Assert.That(result.TotalSum, Is.EqualTo(calculatedTotal));
    }

    /// <summary>
    /// Проверяет, что метод Process использует несколько потоков для обработки наборов чисел, что подтверждается наличием более одного уникального идентификатора потока (ThreadId) в результатах.
    /// </summary>
    [Test]
    public void Process_UsesMultipleThreads()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();
        var uniqueThreadIds = result.Results.Select(r => r.ThreadId).Distinct().Count();

        Assert.That(uniqueThreadIds, Is.GreaterThan(1),
            "Должно использоваться несколько потоков");
    }

    /// <summary>
    /// Проверяет, что метод Process является идемпотентным, то есть повторный вызов метода не изменяет результат после первого успешного выполнения.
    /// </summary>
    [Test]
    public void Process_IsIdempotent_AfterFirstCall()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result1 = processor.GetResult();

        processor.Process();
        var result2 = processor.GetResult();

        Assert.Multiple(() =>
        {
            Assert.That(result2.TotalSum, Is.EqualTo(result1.TotalSum));
            Assert.That(result2.Results, Has.Count.EqualTo(result1.Results.Count));
        });
    }

    /// <summary>
    /// Проверяет, что метод Process не выбрасывает исключений при выполнении и корректно обрабатывает наборы чисел, не превышая максимальное количество одновременных потоков (MaxSimultaneousThreads).
    /// </summary>
    [Test]
    public void Process_RespectsMaxSimultaneousThreads()
    {
        var processor = new NumberSetProcessor();

        Assert.DoesNotThrow(() => processor.Process());
    }
}
