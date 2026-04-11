using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Набор unit-тестов для класса Image.
    /// </summary>
    [TestFixture]
    public class ImageTests
    {
        /// <summary>
        /// Проверяет создание Image с src и alt.
        /// </summary>
        [Test]
        public void Constructor_CreatesImage_WithCorrectProperties()
        {
            var image = new Image("https://example.com/pic.jpg", "Описание изображения");

            Assert.That(image.Src, Is.EqualTo("https://example.com/pic.jpg"),
                "Свойство Src должно содержать переданный путь");
            Assert.That(image.Alt, Is.EqualTo("Описание изображения"),
                "Свойство Alt должно содержать переданный альтернативный текст");
        }

        /// <summary>
        /// Проверяет конструктор Image с минимальными параметрами (только src).
        /// </summary>
        [Test]
        public void Constructor_WithOnlySrc_SetsEmptyAlt()
        {
            var image = new Image("photo.png");

            Assert.That(image.Src, Is.EqualTo("photo.png"));
            Assert.That(image.Alt, Is.EqualTo(string.Empty),
                "Если alt не передан, он должен быть пустой строкой");
        }

        /// <summary>
        /// Проверяет обработку null значений в конструкторе Image.
        /// </summary>
        [Test]
        public void Constructor_WithNullValues_SetsEmptyStrings()
        {
            var image = new Image(null!, null!);

            Assert.That(image.Src, Is.EqualTo(string.Empty));
            Assert.That(image.Alt, Is.EqualTo(string.Empty));
        }

        /// <summary>
        /// Проверяет, что Accept вызывает правильный метод Visit у HtmlVisitor.
        /// </summary>
        [Test]
        public void Accept_CallsVisitImage_OnHtmlVisitor()
        {
            var image = new Image("test.jpg", "Тестовая картинка");
            var visitor = new HtmlVisitor();

            image.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("<img src=\"test.jpg\" alt=\"Тестовая картинка\">"),
                "Accept должен вызвать Visit(Image) и сформировать корректный HTML-тег");
        }

        /// <summary>
        /// Проверяет Accept с MarkdownVisitor.
        /// </summary>
        [Test]
        public void Accept_CallsVisitImage_OnMarkdownVisitor()
        {
            var image = new Image("image.png", "Альтернативный текст");
            var visitor = new MarkdownVisitor();

            image.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("![Альтернативный текст](image.png)"),
                "Accept должен сформировать Markdown-синтаксис изображения");
        }
    }
}
