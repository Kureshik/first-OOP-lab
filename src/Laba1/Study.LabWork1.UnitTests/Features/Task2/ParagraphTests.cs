using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Набор unit-тестов для класса Paragraph.
    /// </summary>
    [TestFixture]
    public class ParagraphTests
    {
        /// <summary>
        /// Проверяет создание Paragraph с обычным текстом.
        /// </summary>
        [Test]
        public void Constructor_CreatesParagraph_WithCorrectText()
        {
            var paragraph = new Paragraph("Это тестовый текст параграфа.");

            Assert.That(paragraph.Text, Is.EqualTo("Это тестовый текст параграфа."),
                "Свойство Text должно содержать переданный текст");
        }

        /// <summary>
        /// Проверяет обработку null в конструкторе Paragraph.
        /// </summary>
        [Test]
        public void Constructor_WithNullText_SetsEmptyString()
        {
            var paragraph = new Paragraph(null!);

            Assert.That(paragraph.Text, Is.EqualTo(string.Empty),
                "При передаче null конструктор должен устанавливать пустую строку");
        }

        /// <summary>
        /// Проверяет, что метод Accept вызывает правильный Visit у посетителя.
        /// </summary>
        [Test]
        public void Accept_CallsVisitParagraph_OnVisitor()
        {
            var paragraph = new Paragraph("Тест Accept");
            var visitor = new HtmlVisitor();

            paragraph.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("<p>Тест Accept</p>"),
                "Accept должен вызвать Visit(Paragraph) у HtmlVisitor");
        }

        /// <summary>
        /// Проверяет Accept с MarkdownVisitor.
        /// </summary>
        [Test]
        public void Accept_CallsVisitParagraph_OnMarkdownVisitor()
        {
            var paragraph = new Paragraph("Markdown тест");
            var visitor = new MarkdownVisitor();

            paragraph.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("Markdown тест"),
                "Accept должен корректно обработать параграф в MarkdownVisitor");
        }
    }
}
