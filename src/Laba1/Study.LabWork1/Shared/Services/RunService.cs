using Study.LabWork1.Features.Task1;
using Study.LabWork1.Shared.Abstractions;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
public class RunService : IRunService
{
    /// <summary>
    /// Задание 1 - Реализация обобщённого класса MySet
    /// </summary>
    public void RunTask1()
    {
        Console.WriteLine("=== Задание 1: MySet<T> ===\n");

        // Тестовые данные
        var setA = new MySet<int>([1, 2, 3, 4, 5, 2, 3]);
        var setB = new MySet<int>([3, 4, 5, 6, 7]);
        var setC = new MySet<int>([1, 2, 3, 4, 5]);

        Console.WriteLine($"A = {setA}");
        Console.WriteLine($"B = {setB}");
        Console.WriteLine($"C = {setC}\n");

        Console.WriteLine($"A | B = {setA | setB}");
        Console.WriteLine($"A & B = {setA & setB}");
        Console.WriteLine($"A - B = {setA - setB}");
        Console.WriteLine($"A / B = {setA / setB}\n");

        Console.WriteLine($"A == C: {setA == setC}");
        Console.WriteLine($"A != B: {setA != setB}");

        // Проверка иммутабельности
        var original = new MySet<string>(new[] { "apple", "banana" });
        var modified = original | new MySet<string>(new[] { "cherry", "date" });

        Console.WriteLine($"Original:  {original}");
        Console.WriteLine($"Modified:  {modified}");
        Console.WriteLine($"Original не изменился: {original}\n");
    }

    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
