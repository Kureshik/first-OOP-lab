using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Набор unit-тестов для класса Document — контейнера элементов документа в паттерне Visitor.
    /// </summary>
    [TestFixture]
    public class DocumentTests
    {
        /// <summary>
        /// Проверяет, что документ успешно создаётся и изначально пуст.
        /// </summary>
        [Test]
        public void Document_CanBeCreated_AndIsInitiallyEmpty()
        {
            var document = new Document();

            Assert.That(document, Is.Not.Null, "Документ должен успешно создаваться");
        }

        /// <summary>
        /// Проверяет добавление элементов в документ через метод Add.
        /// </summary>
        [Test]
        public void Add_Method_AddsElementsToDocument()
        {
            var document = new Document();
            var paragraph = new Paragraph("Тестовый параграф");
            var image = new Image("image.jpg", "Описание");
            var table = new Table(2, 3);

            document.Add(paragraph);
            document.Add(image);
            document.Add(table);

            var htmlVisitor = new HtmlVisitor();
            string result = document.Export(htmlVisitor);

            Assert.That(result, Does.Contain("<p>Тестовый параграф</p>"),
                "Добавленный параграф должен появиться при экспорте");
            Assert.That(result, Does.Contain("image.jpg"),
                "Добавленное изображение должно появиться при экспорте");
            Assert.That(result, Does.Contain("Таблица 2x3"),
                "Добавленная таблица должна появиться при экспорте");
        }

        /// <summary>
        /// Проверяет, что можно добавлять несколько элементов одного типа.
        /// </summary>
        [Test]
        public void Add_Method_AllowsMultipleElementsOfSameType()
        {
            var document = new Document();

            document.Add(new Paragraph("Первый параграф"));
            document.Add(new Paragraph("Второй параграф"));
            document.Add(new Paragraph("Третий параграф"));

            var mdVisitor = new MarkdownVisitor();
            string result = document.Export(mdVisitor);

            Assert.That(result, Does.Contain("Первый параграф"));
            Assert.That(result, Does.Contain("Второй параграф"));
            Assert.That(result, Does.Contain("Третий параграф"));
            Assert.That(result.Split('\n').Count(line => line.Contains("параграф")), Is.EqualTo(3),
                "Все добавленные параграфы должны быть экспортированы");
        }

        /// <summary>
        /// Проверяет корректную работу экспорта документа в HTML формат.
        /// </summary>
        [Test]
        public void Export_WithHtmlVisitor_ReturnsValidHtml()
        {
            var document = CreateTestDocument();

            var visitor = new HtmlVisitor();
            string html = document.Export(visitor);

            Assert.That(html, Is.Not.Null.And.Not.Empty, "Результат экспорта в HTML не должен быть пустым");
            Assert.That(html, Does.Contain("<p>"), "HTML должен содержать открывающие теги параграфов");
            Assert.That(html, Does.Contain("</p>"), "HTML должен содержать закрывающие теги параграфов");
            Assert.That(html, Does.Contain("<img"), "HTML должен содержать тег изображения");
            Assert.That(html, Does.Contain("<table"), "HTML должен содержать тег таблицы");
        }

        /// <summary>
        /// Проверяет корректную работу экспорта документа в Markdown формат.
        /// </summary>
        [Test]
        public void Export_WithMarkdownVisitor_ReturnsValidMarkdown()
        {
            var document = CreateTestDocument();

            var visitor = new MarkdownVisitor();
            string markdown = document.Export(visitor);

            Assert.That(markdown, Is.Not.Null.And.Not.Empty, "Результат экспорта в Markdown не должен быть пустым");
            Assert.That(markdown, Does.Contain("Это тестовый параграф"),
                "Markdown должен содержать текст параграфа");
            Assert.That(markdown, Does.Contain("![Альтернативный текст](test-image.jpg)"),
                "Markdown должен содержать изображение в правильном синтаксисе");
            Assert.That(markdown, Does.Contain("**Таблица"),
                "Markdown должен содержать форматирование таблицы");
        }

        /// <summary>
        /// Проверяет, что экспорт пустого документа возвращает пустую строку.
        /// </summary>
        [Test]
        public void Export_EmptyDocument_ReturnsEmptyString()
        {
            var emptyDocument = new Document();

            var htmlResult = emptyDocument.Export(new HtmlVisitor());
            var mdResult = emptyDocument.Export(new MarkdownVisitor());

            Assert.That(htmlResult, Is.Empty, "Экспорт пустого документа в HTML должен возвращать пустую строку");
            Assert.That(mdResult, Is.Empty, "Экспорт пустого документа в Markdown должен возвращать пустую строку");
        }

        /// <summary>
        /// Проверяет, что порядок добавления элементов сохраняется при экспорте.
        /// </summary>
        [Test]
        public void Export_PreservesOrderOfAddedElements()
        {
            var document = new Document();

            document.Add(new Paragraph("Первый"));
            document.Add(new Image("img1.jpg"));
            document.Add(new Paragraph("Второй"));

            var mdVisitor = new MarkdownVisitor();
            string result = document.Export(mdVisitor);

            // Проверяем порядок появления в результате
            int pos1 = result.IndexOf("Первый");
            int posImg = result.IndexOf("img1.jpg");
            int pos2 = result.IndexOf("Второй");

            Assert.That(pos1, Is.LessThan(posImg), "Порядок элементов должен сохраняться: параграф перед изображением");
            Assert.That(posImg, Is.LessThan(pos2), "Порядок элементов должен сохраняться: изображение перед вторым параграфом");
        }

        /// <summary>
        /// Вспомогательный метод для создания тестового документа с разными элементами.
        /// </summary>
        /// <returns>Заполненный тестовый документ</returns>
        private Document CreateTestDocument()
        {
            var doc = new Document();
            doc.Add(new Paragraph("Это тестовый параграф"));
            doc.Add(new Image("test-image.jpg", "Альтернативный текст"));
            doc.Add(new Table(2, 2));
            return doc;
        }
    }
}
