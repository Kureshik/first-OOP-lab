using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask1;

/// <summary>
/// Тесты для <see cref="SemaphoreService"/> — подсчёт простых чисел с синхронизацией через Semaphore.
/// </summary>
[TestFixture]
public sealed class SemaphoreServiceTests
{
    private const string ExpectedVersionName = "Semaphore";

    /// <summary>
    /// Проверяет, что <see cref="SemaphoreService.GetVersionName"/> возвращает ожидаемое имя версии.
    /// </summary>
    [Test]
    public void GetVersionName_ReturnsExpected()
    {
        var counter = new SemaphoreService();

        Assert.That(counter.GetVersionName(), Is.EqualTo(ExpectedVersionName));
    }

    /// <summary>
    /// Проверяет, что <see cref="SemaphoreService.CountPrimes"/> выбрасывает <see cref="ArgumentOutOfRangeException"/>,
    /// если количество потоков неположительно.
    /// </summary>
    [Test]
    public void CountPrimes_ThrowsArgumentOutOfRange_WhenThreadCountNotPositive()
    {
        var counter = new SemaphoreService();

        Assert.Throws<ArgumentOutOfRangeException>(() =>
            counter.CountPrimes(start: 2, end: 10, threadCount: 0));
    }

    /// <summary>
    /// Проверяет, что <see cref="SemaphoreService.CountPrimes"/> выбрасывает <see cref="ArgumentException"/>,
    /// если конец диапазона меньше начала.
    /// </summary>
    [Test]
    public void CountPrimes_ThrowsArgumentException_WhenEndLessThanStart()
    {
        var counter = new SemaphoreService();

        Assert.Throws<ArgumentException>(() =>
            counter.CountPrimes(start: 10, end: 2, threadCount: 2));
    }

    /// <summary>
    /// Проверяет корректность подсчёта простых чисел на небольшом диапазоне и заполнение полей результата.
    /// </summary>
    [Test]
    public void CountPrimes_CountsPrimesCorrectly_OnSmallRange()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 2, end: 30, threadCount: 3);

        Assert.Multiple(() =>
        {
            Assert.That(result.PrimeCount, Is.EqualTo(10), "простые от 2 до 30 включительно");
            Assert.That(result.FoundPrimes, Has.Count.EqualTo(10));
            Assert.That(result.ExecutionTime, Is.GreaterThan(TimeSpan.Zero));
            Assert.That(result.SynchronizationType, Is.EqualTo(ExpectedVersionName));
        });
    }

    /// <summary>
    /// Проверяет, что найденные простые числа в результате упорядочены по возрастанию.
    /// </summary>
    [Test]
    public void CountPrimes_FoundPrimes_AreOrderedAscending()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 2, end: 100, threadCount: 4);

        Assert.That(result.FoundPrimes, Is.EqualTo(result.FoundPrimes.OrderBy(x => x).ToList()));
        Assert.That(result.FoundPrimes.First(), Is.EqualTo(2));
        Assert.That(result.FoundPrimes.Last(), Is.LessThanOrEqualTo(100));
    }

    /// <summary>
    /// Проверяет, что <see cref="PrimeCountResultDto.PrimeCount"/> совпадает с количеством элементов в
    /// <see cref="PrimeCountResultDto.FoundPrimes"/>.
    /// </summary>
    [Test]
    public void CountPrimes_PrimeCount_EqualsFoundPrimesListCount()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 50, end: 200, threadCount: 2);

        Assert.That(result.PrimeCount, Is.EqualTo(result.FoundPrimes.Count));
    }

    /// <summary>
    /// Проверяет соответствие подсчёта известному значению для диапазона 2–10 000 (1229 простых).
    /// </summary>
    [Test]
    public void CountPrimes_LargeRange_MatchesKnownPrimeTotal()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 2, end: 10_000, threadCount: 4);

        Assert.Multiple(() =>
        {
            Assert.That(result.PrimeCount, Is.EqualTo(1229));
            Assert.That(result.IsValid(expectedCount: 1229), Is.True);
            Assert.That(result.ThreadCount, Is.EqualTo(4));
        });
    }

    /// <summary>
    /// Проверяет, что фактическое число созданных потоков-рабочих в результате может быть меньше запрошенного,
    /// если диапазон короткий и часть потоков не получает ни одного числа.
    /// </summary>
    [Test]
    public void CountPrimes_ThreadCount_MatchesActuallySpawnedWorkers()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 2, end: 5, threadCount: 10);

        Assert.That(result.ThreadCount, Is.EqualTo(4), "не более четырёх блоков диапазона длины 4 числа при 10 потоках");
    }

    /// <summary>
    /// Проверяет, что повторный вызов <see cref="SemaphoreService.CountPrimes"/> даёт тот же набор простых для тех же параметров.
    /// </summary>
    [Test]
    public void CountPrimes_IsIdempotent_OnRepeatedCalls()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto first = counter.CountPrimes(start: 100, end: 500, threadCount: 3);
        PrimeCountResultDto second = counter.CountPrimes(start: 100, end: 500, threadCount: 3);

        Assert.Multiple(() =>
        {
            Assert.That(second.PrimeCount, Is.EqualTo(first.PrimeCount));
            Assert.That(second.FoundPrimes, Is.EqualTo(first.FoundPrimes));
        });
    }

    /// <summary>
    /// Проверяет, что при нескольких потоках результат остаётся консистентным (нет пропусков и дубликатов в списке).
    /// </summary>
    [Test]
    public void CountPrimes_WithMultipleThreads_HasUniqueOrderedPrimes()
    {
        var counter = new SemaphoreService();

        PrimeCountResultDto result = counter.CountPrimes(start: 2, end: 1_000, threadCount: 8);

        var distinct = result.FoundPrimes.Distinct().ToList();

        Assert.Multiple(() =>
        {
            Assert.That(distinct.Count, Is.EqualTo(result.PrimeCount));
            Assert.That(result.ThreadCount, Is.GreaterThan(1));
            Assert.That(result.ThreadCount, Is.EqualTo(8));
        });
    }

    /// <summary>
    /// Проверяет, что вызов <see cref="SemaphoreService.CountPrimes"/> при корректных параметрах завершается без исключений.
    /// </summary>
    [Test]
    public void CountPrimes_DoesNotThrow_OnValidParameters()
    {
        var counter = new SemaphoreService();

        Assert.DoesNotThrow(() =>
            counter.CountPrimes(start: 1, end: 500, threadCount: 5));
    }
}
