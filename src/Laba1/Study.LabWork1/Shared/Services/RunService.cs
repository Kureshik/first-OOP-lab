using Study.LabWork1.Features.Task3;
using Study.LabWork1.Shared.Abstractions;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
public class RunService : IRunService
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public void RunTask1() => throw new NotImplementedException();

    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3 — Простое дерево с рекурсивным выводом
    /// </summary>
    public void RunTask3()
    {
        Console.WriteLine("=== Задание 3: Простое дерево (TreeNode) ===\n");

        var root = new TreeNode<string>("Корень (A)");

        var b = new TreeNode<string>("B");
        var c = new TreeNode<string>("C");
        var d = new TreeNode<string>("D");
        var e = new TreeNode<string>("E");
        var f = new TreeNode<string>("F");
        var g = new TreeNode<string>("G");

        root.AddChild(b);
        root.AddChild(c);

        b.AddChild(d);
        b.AddChild(e);

        c.AddChild(f);
        c.AddChild(g);

        Console.WriteLine("Структура дерева:");
        root.Print();

        Console.WriteLine("\nДерево успешно построено!");
    }
}
