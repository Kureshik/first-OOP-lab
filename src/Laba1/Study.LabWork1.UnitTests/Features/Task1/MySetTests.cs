using Study.LabWork1.Features.Task1;

namespace Study.LabWork1.UnitTests.Features.Task1
{
    /// <summary>
    /// Тестирование множеста
    /// </summary>
    [TestFixture]
    public class MySetTests
    {
        /// <summary>
        /// Тестирование конструктора на удаление дубликатов
        /// </summary>
        [Test]
        public void Constructor_RemovesDuplicates_AndKeepsUniqueElements()
        {
            var set = new MySet<int>(new[] { 1, 2, 2, 3, 3, 3, 4, 5, 5 });

            Assert.That(set.Count, Is.EqualTo(5), "Конструктор должен удалять дубликаты и сохранять только уникальные элементы");
            Assert.That(set.Items, Is.EquivalentTo(new[] { 1, 2, 3, 4, 5 }),
                "Свойство Items должно содержать все уникальные элементы из переданной коллекции");
        }

        /// <summary>
        /// Тестирование конструктора на пустое множество
        /// </summary>
        [Test]
        public void Constructor_EmptyCollection_CreatesEmptySet()
        {
            var set = new MySet<string>(new List<string>());

            Assert.That(set.Count, Is.EqualTo(0), "Конструктор с пустой коллекцией должен создавать пустое множество");
            Assert.That(set.ToString(), Is.EqualTo("{}"), "ToString() пустого множества должен возвращать {}");
        }

        /// <summary>
        /// Тестирование преобразование множества в строку
        /// </summary>
        [Test]
        public void ToString_ReturnsCorrectFormat()
        {
            var set = new MySet<int>(new[] { 10, 20, 30 });

            Assert.That(set.ToString(), Is.EqualTo("{10, 20, 30}"),
                "ToString() должен возвращать строку в формате {elem1, elem2, elem3}");
        }

        /// <summary>
        /// Тестирование преобразования в строку пустого множества
        /// </summary>
        [Test]
        public void ToString_EmptySet_ReturnsEmptyBraces()
        {
            var set = new MySet<double>();

            Assert.That(set.ToString(), Is.EqualTo("{}"),
                "ToString() для пустого множества должен возвращать {}");
        }

        /// <summary>
        /// Тестирование объединения множеств
        /// </summary>
        [Test]
        public void Union_Operator_ReturnsNewSetWithCombinedUniqueElements()
        {
            var setA = new MySet<int>(new[] { 1, 2, 3, 4, 5 });
            var setB = new MySet<int>(new[] { 3, 4, 5, 6, 7 });

            var result = setA | setB;

            Assert.That(result.Count, Is.EqualTo(7), "Объединение множеств должно содержать все уникальные элементы из обоих множеств");
            Assert.That(result.Items, Is.EquivalentTo(new[] { 1, 2, 3, 4, 5, 6, 7 }),
                "Результат объединения должен включать элементы из A и B без дубликатов");
            Assert.That(result.ToString(), Is.EqualTo("{1, 2, 3, 4, 5, 6, 7}"),
                "ToString() объединения должен быть в корректном формате");
        }

        /// <summary>
        /// Тестирование пересечения множеств
        /// </summary>
        [Test]
        public void Intersection_Operator_ReturnsCommonElements()
        {
            var setA = new MySet<int>(new[] { 1, 2, 3, 4, 5 });
            var setB = new MySet<int>(new[] { 3, 4, 5, 6, 7 });

            var result = setA & setB;

            Assert.That(result.Count, Is.EqualTo(3), "Пересечение должно содержать только общие элементы");
            Assert.That(result.Items, Is.EquivalentTo(new[] { 3, 4, 5 }),
                "Результат пересечения должен включать только элементы, присутствующие в обоих множествах");
        }

        /// <summary>
        /// Тестирование разности множеств
        /// </summary>
        [Test]
        public void Difference_Operator_ReturnsElementsOnlyInFirstSet()
        {
            var setA = new MySet<int>(new[] { 1, 2, 3, 4, 5 });
            var setB = new MySet<int>(new[] { 3, 4, 5, 6, 7 });

            var result = setA - setB;

            Assert.That(result.Count, Is.EqualTo(2), "Разность A - B должна содержать элементы, которые есть только в A");
            Assert.That(result.Items, Is.EquivalentTo(new[] { 1, 2 }),
                "Результат разности должен исключать все элементы из B");
        }

        /// <summary>
        /// Тестирование симметричной разности множеств
        /// </summary>
        [Test]
        public void SymmetricDifference_Operator_ReturnsElementsInEitherButNotBoth()
        {
            var setA = new MySet<int>(new[] { 1, 2, 3, 4, 5 });
            var setB = new MySet<int>(new[] { 3, 4, 5, 6, 7 });

            var result = setA / setB;

            Assert.That(result.Count, Is.EqualTo(4), "Симметричная разность должна содержать элементы, которые есть только в одном из множеств");
            Assert.That(result.Items, Is.EquivalentTo(new[] { 1, 2, 6, 7 }),
                "Результат A / B должен включать элементы из A и B, исключая общие");
        }

        /// <summary>
        /// Тестирование сравнения множеств
        /// </summary>
        [Test]
        public void EqualityOperator_ComparesByValue_NotByReference()
        {
            var setA = new MySet<int>(new[] { 1, 2, 3, 4, 5 });
            var setB = new MySet<int>(new[] { 5, 4, 3, 2, 1 }); // другой порядок элементов
            var setC = new MySet<int>(new[] { 1, 2, 3, 4, 6 });

            Assert.That(setA == setB, Is.True, "Оператор == должен сравнивать множества по значениям, а не по порядку или ссылке");
            Assert.That(setA == setC, Is.False, "Множества с разными элементами не должны быть равны");
            Assert.That(setA != setC, Is.True, "Оператор != должен возвращать true для неравных множеств");
        }

        /// <summary>
        /// Тестирование неизменности множества
        /// </summary>
        [Test]
        public void Immutability_SetOperations_ReturnNewInstance_OriginalUnchanged()
        {
            var original = new MySet<int>(new[] { 1, 2, 3 });

            var unionResult = original | new MySet<int>(new[] { 4, 5 });
            var intersectResult = original & new MySet<int>(new[] { 2, 3, 6 });

            Assert.That(original.Count, Is.EqualTo(3),
                "Оригинальное множество не должно изменяться после выполнения операций (иммутабельность)");
            Assert.That(original.ToString(), Is.EqualTo("{1, 2, 3}"),
                "Содержимое оригинального множества должно остаться прежним");

            Assert.That(unionResult.Count, Is.EqualTo(5),
                "Результат операции должен быть новым экземпляром множества");
            Assert.That(intersectResult.Count, Is.EqualTo(2),
                "Каждая операция должна возвращать новый объект MySet<T>");
        }

        /// <summary>
        /// Тестирование множества на доступ только на чтение
        /// </summary>
        [Test]
        public void Items_Property_ReturnsReadOnlyCollection()
        {
            var set = new MySet<char>(new[] { 'a', 'b', 'c' });
            var items = set.Items;

            Assert.That(items, Is.Not.Null, "Свойство Items не должно возвращать null");
            Assert.That(items.Count, Is.EqualTo(3), "Items должен содержать все элементы множества");

            // Проверка, что коллекция readonly
            Assert.Throws<NotSupportedException>(() => ((IList<char>)items).Add('d'),
                "Коллекция Items должна быть доступна только для чтения");
        }

        /// <summary>
        /// Тестирование можества на работу с null
        /// </summary>
        [Test]
        public void NullArguments_ThrowArgumentNullException()
        {
            var set = new MySet<int>(new[] { 1, 2, 3 });

            Assert.Throws<ArgumentNullException>(() => { var _ = set | null!; },
                "Оператор | должен выбрасывать ArgumentNullException при null аргументе");

            Assert.Throws<ArgumentNullException>(() => { var _ = null! & set; },
                "Оператор & должен выбрасывать ArgumentNullException при null аргументе");

            Assert.Throws<ArgumentNullException>(() => { var _ = set - null!; },
                "Оператор - должен выбрасывать ArgumentNullException при null аргументе");

            Assert.Throws<ArgumentNullException>(() => { var _ = null! / set; },
                "Оператор / должен выбрасывать ArgumentNullException при null аргументе");
        }
    }
}
