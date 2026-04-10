namespace Study.LabWork1.Features.Task1
{
    /// <summary>
    /// Обобщённое математическое множество уникальных элементов
    /// </summary>
    public class MySet<T>
    {
        // Внутреннее хранилище - только для чтения после создания
        private readonly List<T> _items;

        /// <summary>
        /// Конструктор, принимающий коллекцию и сохраняющий только уникальные элементы
        /// </summary>
        public MySet(IEnumerable<T> collection)
        {
            _items = new List<T>();

            if (collection != null)
            {
                foreach (var item in collection)
                {
                    if (!Contains(item))
                    {
                        _items.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию (пустое множество)
        /// </summary>
        public MySet() : this(Enumerable.Empty<T>())
        {
        }

        /// <summary>
        /// Количество элементов в множестве (только для чтения)
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Элементы множества (только для чтения)
        /// </summary>
        public IReadOnlyCollection<T> Items => _items.AsReadOnly();

        /// <summary>
        /// Проверка наличия элемента в множестве
        /// </summary>
        private bool Contains(T item)
        {
            return _items.Contains(item);
        }

        /// <summary>
        /// Вывод в требуемом формате: {elem1, elem2, elem3}
        /// </summary>
        public override string ToString()
        {
            if (_items.Count == 0)
                return "{}";

            return $"{{{string.Join(", ", _items)}}}";
        }

        // ====================== Операции над множествами ======================

        /// <summary>
        /// Объединение: A | B
        /// </summary>
        public static MySet<T> operator |(MySet<T> a, MySet<T> b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            var result = new List<T>(a._items);
            foreach (var item in b._items)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }
            return new MySet<T>(result);
        }

        /// <summary>
        /// Пересечение: A & B
        /// </summary>
        public static MySet<T> operator &(MySet<T> a, MySet<T> b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            var result = new List<T>();
            foreach (var item in a._items)
            {
                if (b._items.Contains(item))
                    result.Add(item);
            }
            return new MySet<T>(result);
        }

        /// <summary>
        /// Разность: A - B
        /// </summary>
        public static MySet<T> operator -(MySet<T> a, MySet<T> b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            var result = new List<T>();
            foreach (var item in a._items)
            {
                if (!b._items.Contains(item))
                    result.Add(item);
            }
            return new MySet<T>(result);
        }

        /// <summary>
        /// Симметричная разность: A / B
        /// </summary>
        public static MySet<T> operator /(MySet<T> a, MySet<T> b)
        {
            ArgumentNullException.ThrowIfNull(a);
            ArgumentNullException.ThrowIfNull(b);

            var diffAB = a - b;
            var diffBA = b - a;
            return diffAB | diffBA;
        }

        // ====================== Сравнение ======================

        /// <summary>
        /// Сравнение множеств по значениям (==)
        /// </summary>
        public static bool operator ==(MySet<T> a, MySet<T> b)
        {
            if (a is null || b is null) return false;

            if (a.Count != b.Count) return false;

            foreach (var item in a._items)
            {
                if (!b._items.Contains(item))
                    return false;
            }
            return true;
        }

        public static bool operator !=(MySet<T> a, MySet<T> b) => !(a == b);

        public override bool Equals(object? obj)
        {
            return obj is MySet<T> other && this == other;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                foreach (var item in _items)
                {
                    hash = hash * 31 + (item?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }
    }
}
