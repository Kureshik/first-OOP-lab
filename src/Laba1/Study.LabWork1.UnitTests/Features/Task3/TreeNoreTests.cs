using Study.LabWork1.Features.Task3;

namespace Study.LabWork1.UnitTests.Features.Task3
{
    /// <summary>
    /// Набор unit-тестов для класса <see cref="TreeNode{T}"/> — реализации простого дерева.
    /// </summary>
    [TestFixture]
    public class TreeNodeTests
    {
        /// <summary>
        /// Проверяем создание узла дерева с корректным значением.
        /// </summary>
        [Test]
        public void Constructor_CreatesNode_WithCorrectValue()
        {
            var node = new TreeNode<string>("Корень");

            Assert.That(node.Value, Is.EqualTo("Корень"),
                "Значение узла должно совпадать с переданным в конструктор");
            Assert.That(node.Children, Is.Not.Null,
                "Список Children должен быть инициализирован");
            Assert.That(node.Children.Count, Is.EqualTo(0),
                "Новый узел не должен иметь детей");
        }

        /// <summary>
        /// Проверяем добавление одного ребёнка к узлу.
        /// </summary>
        [Test]
        public void AddChild_AddsSingleChild_Correctly()
        {
            var parent = new TreeNode<string>("Родитель");
            var child = new TreeNode<string>("Ребёнок");

            parent.AddChild(child);

            Assert.That(parent.Children.Count, Is.EqualTo(1),
                "После добавления одного ребёнка количество детей должно быть 1");
            Assert.That(parent.Children[0].Value, Is.EqualTo("Ребёнок"),
                "Добавленный ребёнок должен хранить правильное значение");
        }

        /// <summary>
        /// Проверяем добавление нескольких детей к одному узлу.
        /// </summary>
        [Test]
        public void AddChild_AddsMultipleChildren_Correctly()
        {
            var root = new TreeNode<int>(100);
            root.AddChild(new TreeNode<int>(200));
            root.AddChild(new TreeNode<int>(300));
            root.AddChild(new TreeNode<int>(400));

            Assert.That(root.Children.Count, Is.EqualTo(3),
                "Узел должен содержать три добавленных ребёнка");
            Assert.That(root.Children.Select(c => c.Value),
                Is.EquivalentTo(new[] { 200, 300, 400 }));
        }

        /// <summary>
        /// Проверяем рекурсивный вывод дерева с одним уровнем вложенности.
        /// </summary>
        [Test]
        public void Print_OutputsNodeAndItsDirectChildren()
        {
            var root = new TreeNode<string>("A");
            root.AddChild(new TreeNode<string>("B"));
            root.AddChild(new TreeNode<string>("C"));

            using var sw = new StringWriter();
            Console.SetOut(sw);

            root.Print();

            string output = sw.ToString().Trim();

            Assert.That(output, Does.Contain("A"), "Должен быть выведен корневой узел");
            Assert.That(output, Does.Contain("B"), "Должен быть выведен первый ребёнок");
            Assert.That(output, Does.Contain("C"), "Должен быть выведен второй ребёнок");
        }

        /// <summary>
        /// Проверяем глубокую рекурсивную печать дерева с несколькими уровнями вложенности.
        /// </summary>
        [Test]
        public void Print_OutputsDeepTree_WithCorrectIndentation()
        {
            // дерево:
            //        A
            //       / \
            //      B   C
            //     /     \
            //    D       E
            var root = new TreeNode<string>("A");
            var b = new TreeNode<string>("B");
            var c = new TreeNode<string>("C");
            var d = new TreeNode<string>("D");
            var e = new TreeNode<string>("E");

            root.AddChild(b);
            root.AddChild(c);
            b.AddChild(d);
            c.AddChild(e);

            using var sw = new StringWriter();
            Console.SetOut(sw);

            root.Print();

            string output = sw.ToString();

            Assert.That(output, Does.Contain("A"));
            Assert.That(output, Does.Contain("    B"));   // 4 пробела отступ
            Assert.That(output, Does.Contain("    C"));
            Assert.That(output, Does.Contain("        D")); // 8 пробелов
            Assert.That(output, Does.Contain("        E"));
        }

        /// <summary>
        /// Проверяем, что листовой узел (без детей) корректно завершает рекурсию.
        /// </summary>
        [Test]
        public void Print_LeafNode_OutputsOnlyItsValue()
        {
            var leaf = new TreeNode<int>(999);

            using var sw = new StringWriter();
            Console.SetOut(sw);

            leaf.Print();

            string output = sw.ToString().Trim();

            Assert.That(output, Is.EqualTo("999"),
                "Листовой узел должен выводить только своё значение и не делать дальнейших вызовов");
        }

        /// <summary>
        /// Проверяем работу с числовым типом данных.
        /// </summary>
        [Test]
        public void TreeNode_WorksCorrectly_WithIntegerValues()
        {
            var root = new TreeNode<int>(10);
            root.AddChild(new TreeNode<int>(20));
            root.AddChild(new TreeNode<int>(30));

            using var sw = new StringWriter();
            Console.SetOut(sw);

            root.Print();

            string output = sw.ToString();

            Assert.That(output, Does.Contain("10"));
            Assert.That(output, Does.Contain("    20"));
            Assert.That(output, Does.Contain("    30"));
        }

        /// <summary>
        /// Проверяем, что метод Print корректно обрабатывает null-значения (если T допускает null).
        /// </summary>
        [Test]
        public void Print_HandlesNullValue_Correctly()
        {
            var node = new TreeNode<string?>(null);

            using var sw = new StringWriter();
            Console.SetOut(sw);

            node.Print();

            string output = sw.ToString().Trim();

            Assert.That(output, Is.EqualTo(""),
                "При значении null должен выводиться пустая строка (или null.ToString())");
        }

        /// <summary>
        /// Проверяем, что добавление null-ребёнка не приводит к ошибке.
        /// </summary>
        [Test]
        public void AddChild_IgnoresNullChild()
        {
            var parent = new TreeNode<string>("Parent");
            parent.AddChild(null!);

            Assert.That(parent.Children.Count, Is.EqualTo(0),
                "Добавление null-ребёнка не должно увеличивать количество детей");
        }
    }
}
