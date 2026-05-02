using System.Diagnostics;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

internal static class PrimeCountingShared
{
    public static PrimeCountResultDto CountPrimes(
        int start,
        int end,
        int threadCount,
        string synchronizationType,
        Action<int, List<int>> addPrimeAction)
    {
        if (threadCount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(threadCount), "Количество потоков должно быть больше нуля.");
        }

        if (end < start)
        {
            throw new ArgumentException("Конец диапазона должен быть больше или равен началу.");
        }

        var foundPrimes = new List<int>();
        var workerThreads = new List<Thread>(threadCount);
        var stopwatch = Stopwatch.StartNew();

        var totalNumbers = end - start + 1;
        var chunkSize = totalNumbers / threadCount;
        var remainder = totalNumbers % threadCount;
        var currentStart = start;

        for (var i = 0; i < threadCount; i++)
        {
            var localSize = chunkSize + (i < remainder ? 1 : 0);
            var localStart = currentStart;
            var localEnd = localStart + localSize - 1;
            currentStart = localEnd + 1;

            if (localSize <= 0)
            {
                continue;
            }

            var thread = new Thread(() =>
            {
                for (var number = localStart; number <= localEnd; number++)
                {
                    Console.WriteLine($"[Поток {Environment.CurrentManagedThreadId}] Проверка: {number}");

                    if (!IsPrime(number))
                    {
                        continue;
                    }

                    Console.WriteLine($"[Поток {Environment.CurrentManagedThreadId}] Найдено простое число: {number}");
                    addPrimeAction(number, foundPrimes);
                }
            });

            workerThreads.Add(thread);
        }

        foreach (var thread in workerThreads)
        {
            thread.Start();
        }

        foreach (var thread in workerThreads)
        {
            thread.Join();
        }

        stopwatch.Stop();

        return new PrimeCountResultDto
        {
            PrimeCount = foundPrimes.Count,
            ExecutionTime = stopwatch.Elapsed,
            ThreadCount = workerThreads.Count,
            SynchronizationType = synchronizationType,
            FoundPrimes = foundPrimes.OrderBy(x => x).ToList()
        };
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        var limit = (int)Math.Sqrt(number);

        for (var divisor = 3; divisor <= limit; divisor += 2)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
