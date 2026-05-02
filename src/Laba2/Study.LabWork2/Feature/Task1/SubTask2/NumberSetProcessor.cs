using System.Diagnostics;
using System.Text;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask2;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask2;

/// <summary>
/// Определяет реализацию для процессора наборов чисел
/// </summary>
public class NumberSetProcessor : INumberSetProcessor
{
    private const int SetCount = 15;
    private const int NumbersPerSet = 100;
    private const int MinValue = 1;
    private const int MaxValue = 100;
    private const int MaxSimultaneousThreads = 4;

    private static readonly string DatasetPath = Path.Combine(
        AppContext.BaseDirectory,
        "task1_subtask2_dataset.txt");

    private readonly object _resultsLock = new();
    private readonly Mutex _totalSumMutex = new();
    private readonly Semaphore _semaphore = new(MaxSimultaneousThreads, MaxSimultaneousThreads);

    private ProcessingResultDto? _result;

    /// <inheritdoc />
    public ProcessingResultDto GetResult()
    {
        if (_result is null)
        {
            throw new InvalidOperationException("Обработка наборов чисел не была выполнена. Сначала вызовите метод Process().");
        }

        return _result;
    }

    /// <inheritdoc />
    public void Process()
    {
        var numberSets = LoadOrCreatePersistentDataset();
        var resultEntries = new List<ResultEntryDto>(SetCount);
        var totalSum = 0;
        var threads = new List<Thread>(SetCount);
        var stopwatch = Stopwatch.StartNew();

        for (var index = 0; index < numberSets.Count; index++)
        {
            var setIndex = index;
            var localSet = numberSets[setIndex];

            var thread = new Thread(() =>
            {
                _semaphore.WaitOne();
                try
                {
                    var sum = localSet.Sum();
                    var threadId = Environment.CurrentManagedThreadId;

                    lock (_resultsLock)
                    {
                        resultEntries.Add(new ResultEntryDto
                        {
                            SetNumber = setIndex + 1,
                            Sum = sum,
                            ThreadId = threadId
                        });
                    }

                    _totalSumMutex.WaitOne();
                    try
                    {
                        totalSum += sum;
                    }
                    finally
                    {
                        _totalSumMutex.ReleaseMutex();
                    }
                }
                finally
                {
                    _semaphore.Release();
                }
            });

            threads.Add(thread);
        }

        foreach (var thread in threads)
        {
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        stopwatch.Stop();

        _result = new ProcessingResultDto
        {
            Results = resultEntries.OrderBy(x => x.SetNumber).ToList(),
            TotalSum = totalSum,
            ExecutionTime = stopwatch.Elapsed,
            ProcessedSetsCount = resultEntries.Count
        };
    }

    private static List<int[]> LoadOrCreatePersistentDataset()
    {
        if (!File.Exists(DatasetPath))
        {
            CreateDatasetFile();
        }

        return ParseDataset(File.ReadAllLines(DatasetPath, Encoding.UTF8));
    }

    private static void CreateDatasetFile()
    {
        var seed = string.GetHashCode(Environment.UserName, StringComparison.Ordinal);
        var random = new Random(seed);
        var lines = new List<string>(SetCount);

        for (var i = 0; i < SetCount; i++)
        {
            var values = new int[NumbersPerSet];
            for (var j = 0; j < NumbersPerSet; j++)
            {
                values[j] = random.Next(MinValue, MaxValue + 1);
            }

            lines.Add(string.Join(' ', values));
        }

        File.WriteAllLines(DatasetPath, lines, Encoding.UTF8);
    }

    private static List<int[]> ParseDataset(string[] lines)
    {
        if (lines.Length != SetCount)
        {
            throw new InvalidDataException($"Данные набора чисел должны содержать ровно {SetCount} наборов.");
        }

        var result = new List<int[]>(SetCount);

        for (var i = 0; i < lines.Length; i++)
        {
            var parts = lines[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            if (parts.Length != NumbersPerSet)
            {
                throw new InvalidDataException(
                    $"Набор #{i + 1} должен содержать ровно {NumbersPerSet} чисел.");
            }

            var parsed = new int[NumbersPerSet];
            for (var j = 0; j < parts.Length; j++)
            {
                if (!int.TryParse(parts[j], out var value))
                {
                    throw new InvalidDataException($"Неверное число '{parts[j]}' в наборе #{i + 1}.");
                }

                if (value < MinValue || value > MaxValue)
                {
                    throw new InvalidDataException(
                        $"Значение {value} в наборе #{i + 1} выходит за допустимый диапазон [{MinValue}, {MaxValue}].");
                }

                parsed[j] = value;
            }

            result.Add(parsed);
        }

        return result;
    }
}
