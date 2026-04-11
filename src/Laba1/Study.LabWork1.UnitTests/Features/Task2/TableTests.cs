using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Набор unit-тестов для класса Table.
    /// </summary>
    [TestFixture]
    public class TableTests
    {
        /// <summary>
        /// Проверяет создание таблицы с заданными размерами.
        /// </summary>
        [Test]
        public void Constructor_CreatesTable_WithCorrectDimensions()
        {
            var table = new Table(5, 3);

            Assert.That(table.Rows, Is.EqualTo(5), "Свойство Rows должно возвращать переданное количество строк");
            Assert.That(table.Columns, Is.EqualTo(3), "Свойство Columns должно возвращать переданное количество столбцов");
        }

        /// <summary>
        /// Проверяет создание таблицы с минимальными размерами (1x1).
        /// </summary>
        [Test]
        public void Constructor_AllowesMinimalTableSize()
        {
            var table = new Table(1, 1);

            Assert.That(table.Rows, Is.EqualTo(1));
            Assert.That(table.Columns, Is.EqualTo(1));
        }

        /// <summary>
        /// Проверяет, что Accept вызывает правильный Visit у HtmlVisitor.
        /// </summary>
        [Test]
        public void Accept_CallsVisitTable_OnHtmlVisitor()
        {
            var table = new Table(4, 2);
            var visitor = new HtmlVisitor();

            table.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("<table border=\"1\">"),
                "Accept должен вызвать Visit(Table) и сформировать HTML-таблицу");
            Assert.That(result, Does.Contain("Таблица 4x2"),
                "HTML должен содержать информацию о размерах таблицы");
        }

        /// <summary>
        /// Проверяет Accept с MarkdownVisitor (включая таблицу).
        /// </summary>
        [Test]
        public void Accept_CallsVisitTable_OnMarkdownVisitor()
        {
            var table = new Table(3, 4);
            var visitor = new MarkdownVisitor();

            table.Accept(visitor);

            string result = visitor.GetResult();
            Assert.That(result, Does.Contain("**Таблица 3x4**"),
                "MarkdownVisitor должен вывести заголовок таблицы");
            Assert.That(result, Does.Contain("| Колонка 1 |"),
                "Markdown должен содержать шапку таблицы");
        }

        /// <summary>
        /// Проверяет, что таблица с большими размерами корректно обрабатывается.
        /// </summary>
        [Test]
        public void Table_WithLargeDimensions_WorksCorrectly()
        {
            var table = new Table(10, 5);
            var visitor = new MarkdownVisitor();

            table.Accept(visitor);
            string result = visitor.GetResult();

            Assert.That(result, Does.Contain("**Таблица 10x5**"));
        }
    }
}
