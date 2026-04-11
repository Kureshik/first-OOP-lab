using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Набор unit-тестов для проверки корректности реализации паттерна Visitor.
    /// Тестирует экспорт документа в HTML и Markdown форматы.
    /// </summary>
    [TestFixture]
    public class VisitorTests
    {
        private Document _document;

        /// <summary>
        /// Инициализация тестового документа перед каждым тестом.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _document = new Document();

            _document.Add(new Paragraph("Это первый параграф текста."));
            _document.Add(new Image("https://example.com/photo.jpg", "Красивое фото"));
            _document.Add(new Table(3, 4));
            _document.Add(new Paragraph("Это заключительный параграф."));
        }

        /// <summary>
        /// Проверяет, что HtmlVisitor корректно экспортирует все элементы документа в HTML.
        /// </summary>
        [Test]
        public void HtmlVisitor_ExportsCorrectHtmlStructure()
        {
            var htmlVisitor = new HtmlVisitor();

            string result = _document.Export(htmlVisitor);

            Assert.That(result, Is.Not.Empty, "Результат экспорта в HTML не должен быть пустым");
            Assert.That(result, Does.Contain("<p>Это первый параграф текста.</p>"),
                "HTML должен содержать параграф с правильным текстом");
            Assert.That(result, Does.Contain("<img src=\"https://example.com/photo.jpg\" alt=\"Красивое фото\">"),
                "HTML должен содержать изображение с корректными атрибутами");
            Assert.That(result, Does.Contain("<table border=\"1\">"),
                "HTML должен содержать таблицу");
            Assert.That(result, Does.Contain("Таблица 3x4"),
                "HTML должен содержать информацию о размерах таблицы");
        }

        /// <summary>
        /// Проверяет, что MarkdownVisitor корректно экспортирует все элементы документа в Markdown,
        /// включая сложное форматирование таблицы.
        /// </summary>
        [Test]
        public void MarkdownVisitor_ExportsCorrectMarkdownStructure()
        {
            var mdVisitor = new MarkdownVisitor();

            string result = _document.Export(mdVisitor);

            Assert.That(result, Is.Not.Empty, "Результат экспорта в Markdown не должен быть пустым");
            Assert.That(result, Does.Contain("Это первый параграф текста."),
                "Markdown должен содержать текст параграфа");
            Assert.That(result, Does.Contain("![Красивое фото](https://example.com/photo.jpg)"),
                "Markdown должен содержать изображение в правильном формате");
            Assert.That(result, Does.Contain("**Таблица 3x4**"),
                "Markdown должен содержать заголовок таблицы");
            Assert.That(result, Does.Contain("| Колонка 1 | Колонка 2 | Колонка 3 | Колонка 4 |"),
                "Markdown должен содержать шапку таблицы");
            Assert.That(result, Does.Contain("| --- | --- | --- | --- |"),
                "Markdown должен содержать разделитель таблицы");
        }

        /// <summary>
        /// Проверяет, что метод Export с HtmlVisitor возвращает непустой результат.
        /// </summary>
        [Test]
        public void Document_Export_WithHtmlVisitor_ReturnsNonEmptyResult()
        {
            var htmlVisitor = new HtmlVisitor();
            string html = _document.Export(htmlVisitor);

            Assert.That(html, Is.Not.Null.And.Not.Empty, "Экспорт в HTML не должен возвращать null или пустую строку");
            Assert.That(html, Does.Contain("<p>"), "Результат должен содержать HTML-теги параграфа");
            Assert.That(html, Does.Contain("</p>"), "Результат должен содержать закрывающие HTML-теги");
        }

        /// <summary>
        /// Проверяет, что метод Export с MarkdownVisitor возвращает непустой результат.
        /// </summary>
        [Test]
        public void Document_Export_WithMarkdownVisitor_ReturnsNonEmptyResult()
        {
            var mdVisitor = new MarkdownVisitor();
            string markdown = _document.Export(mdVisitor);

            Assert.That(markdown, Is.Not.Null.And.Not.Empty,
                "Экспорт в Markdown не должен возвращать null или пустую строку");
            Assert.That(markdown, Does.Contain("Таблица"),
                "Markdown должен содержать информацию о таблице");
        }

        /// <summary>
        /// Проверяет, что метод Accept элемента Paragraph корректно вызывает Visit у HtmlVisitor.
        /// </summary>
        [Test]
        public void Accept_Method_CallsCorrectVisitMethod_OnHtmlVisitor()
        {
            var htmlVisitor = new HtmlVisitor();
            var paragraph = new Paragraph("Тестовый текст");

            paragraph.Accept(htmlVisitor);

            string result = htmlVisitor.GetResult();

            Assert.That(result, Does.Contain("<p>Тестовый текст</p>"),
                "Accept должен вызвать Visit(Paragraph) и добавить параграф в HTML");
        }

        /// <summary>
        /// Проверяет, что метод Accept элемента Image корректно вызывает Visit у MarkdownVisitor.
        /// </summary>
        [Test]
        public void Accept_Method_CallsCorrectVisitMethod_OnMarkdownVisitor()
        {
            var mdVisitor = new MarkdownVisitor();
            var image = new Image("test.jpg", "Тестовое изображение");

            image.Accept(mdVisitor);

            string result = mdVisitor.GetResult();

            Assert.That(result, Does.Contain("![Тестовое изображение](test.jpg)"),
                "Accept должен вызвать Visit(Image) и добавить изображение в Markdown");
        }

        /// <summary>
        /// Проверяет поведение экспорта пустого документа.
        /// </summary>
        [Test]
        public void EmptyDocument_Export_ReturnsEmptyString()
        {
            var emptyDocument = new Document();
            var visitor = new HtmlVisitor();

            string result = emptyDocument.Export(visitor);

            Assert.That(result, Is.Empty, "Экспорт пустого документа должен возвращать пустую строку");
        }

        /// <summary>
        /// Проверяет, что один и тот же документ можно экспортировать несколько раз 
        /// с помощью новых экземпляров Visitor.
        /// </summary>
        [Test]
        public void Visitor_CanBeUsedMultipleTimes()
        {
            var htmlVisitor1 = new HtmlVisitor();
            var htmlVisitor2 = new HtmlVisitor();

            string firstExport = _document.Export(htmlVisitor1);
            string secondExport = _document.Export(htmlVisitor2);

            Assert.That(secondExport, Is.EqualTo(firstExport),
                "Повторный экспорт с новым Visitor должен давать идентичный результат");
        }
    }
}
