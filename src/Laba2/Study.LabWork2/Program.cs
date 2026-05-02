using Study.LabWork2.Feature.Task1.SubTask2;

namespace Study.LabWork2;

/// <summary>
/// Точка входа в приложение для запуска заданий лабораторной работы.
/// </summary>
public static class Program
{
    /// <summary>
    /// Запускает обработку наборов чисел (SubTask2).
    /// </summary>
    public static void Main()
    {
        var processor = new NumberSetProcessor();
        processor.Process();

        var result = processor.GetResult();

        foreach (var entry in result.Results)
        {
            Console.WriteLine($"Набор #{entry.SetNumber}: сумма = {entry.Sum} (поток {entry.ThreadId})");
        }

        Console.WriteLine($"Общая сумма по всем наборам: {result.TotalSum}");
        Console.WriteLine($"Время выполнения: {result.ExecutionTime.TotalMilliseconds:F2} мс");
    }
}
