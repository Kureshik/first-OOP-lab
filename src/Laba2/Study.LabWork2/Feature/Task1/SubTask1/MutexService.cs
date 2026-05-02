using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 2. Использует Mutex для синхронизации
/// </summary>
public sealed class MutexService : IPrimeCounter
{
    private readonly Mutex _mutex = new();

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
                _mutex.WaitOne();
                try
                {
                    foundPrimes.Add(number);
                }
                finally
                {
                    _mutex.ReleaseMutex();
                }
            });
    }

    /// <inheritdoc/>
    public string GetVersionName() => "Mutex";
}
