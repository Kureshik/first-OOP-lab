using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 3. Использует Semaphore для синхронизации
/// </summary>
public sealed class SemaphoreService : IPrimeCounter
{
    private readonly Semaphore _semaphore = new(1, 1);

    /// <inheritdoc/>
    public PrimeCountResultDto CountPrimes(int start, int end, int threadCount)
    {
        return PrimeCountingShared.CountPrimes(
            start,
            end,
            threadCount,
            GetVersionName(),
            (number, foundPrimes) =>
            {
                _semaphore.WaitOne();
                try
                {
                    foundPrimes.Add(number);
                }
                finally
                {
                    _semaphore.Release();
                }
            });
    }

    /// <inheritdoc/>
    public string GetVersionName() => "Semaphore";
}
