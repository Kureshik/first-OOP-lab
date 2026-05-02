using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

/// <summary>
/// Точка входа в приложение для запуска заданий лабораторной работы.
/// </summary>
public static class Program
{
    /// <summary>
    /// Запускает сравнение трех версий подсчета простых чисел
    /// с разными механизмами синхронизации.
    /// </summary>
    public static void Main()
    {
        const int start = 1;
        const int end = 10_000;
        const int threadCount = 4;

        var versions = new IPrimeCounter[]
        {
            new MonitorService(),
            new MutexService(),
            new SemaphoreService()
        };

        foreach (var version in versions)
        {
            Console.WriteLine(new string('=', 70));
            Console.WriteLine($"Версия: {version.GetVersionName()}");

            var result = version.CountPrimes(start, end, threadCount);

            Console.WriteLine($"Всего простых чисел: {result.PrimeCount}");
            Console.WriteLine($"Время выполнения: {result.ExecutionTime.TotalMilliseconds:F2} мс");
        }
    }
}
