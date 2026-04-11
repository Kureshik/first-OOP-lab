namespace Study.LabWork1.Features.Task3
{
    /// <summary>
    /// Узел простого дерева.
    /// Каждый узел содержит значение и список потомков (детей).
    /// </summary>
    /// <typeparam name="T">Тип значения узла (int, string, объект и т.д.)</typeparam>
    public class TreeNode<T>
    {
        /// <summary>
        /// Значение, хранящееся в узле.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Список всех непосредственных потомков (детей) узла.
        /// </summary>
        public List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

        /// <summary>
        /// Создаёт новый узел дерева с заданным значением.
        /// </summary>
        /// <param name="value">Значение узла</param>
        public TreeNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Рекурсивная функция вывода всего поддерева.
        /// Сначала выводит значение текущего узла, затем рекурсивно вызывает себя для каждого ребёнка.
        /// </summary>
        /// <param name="depth">Текущий уровень вложенности</param>
        public void Print(int depth = 0)
        {
            // 1. Выводим значение текущего узла
            Console.WriteLine(new string(' ', depth * 4) + Value);

            // 2. Проверяем, есть ли дети
            if (Children.Count > 0)
            {
                // 3. Для каждого ребёнка вызываем эту же функцию
                foreach (var child in Children)
                {
                    child.Print(depth + 1);
                }
            }
        }

        /// <summary>
        /// Метод для добавления ребёнка
        /// </summary>
        /// <param name="child">Добавляемый потомок</param>
        public void AddChild(TreeNode<T> child)
        {
            if (child != null)
                Children.Add(child);
        }
    }
}
