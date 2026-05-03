using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 1. Использует Monitor (lock) для синхронизации
/// </summary>
public sealed class MonitorService : IPrimeCounter
{
    private readonly object _syncRoot = new();

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
                lock (_syncRoot)
                {
                    foundPrimes.Add(number);
                }
            }
        );
    }

    /// <inheritdoc/>
    public string GetVersionName() => "Monitor";
}
