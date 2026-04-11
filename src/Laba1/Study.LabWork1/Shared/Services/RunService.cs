using Study.LabWork1.Features.Task2;
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
    public void RunTask2()
    {
        Console.WriteLine("=== Задание: Паттерн Visitor ===\n");

        var document = new Document();

        document.Add(new Paragraph("Добро пожаловать на лекцию по паттернам проектирования."));
        document.Add(new Image("https://example.com/image.jpg", "Схема паттерна"));
        document.Add(new Table(5, 3));
        document.Add(new Paragraph("Конец документа."));

        // Экспорт в HTML
        var htmlVisitor = new HtmlVisitor();
        string html = document.Export(htmlVisitor);
        Console.WriteLine("=== HTML ===");
        Console.WriteLine(html);

        // Экспорт в Markdown
        var mdVisitor = new MarkdownVisitor();
        string markdown = document.Export(mdVisitor);
        Console.WriteLine("\n=== Markdown ===");
        Console.WriteLine(markdown);
    }

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
