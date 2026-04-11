namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Контейнер документа, содержащий коллекцию элементов
    /// </summary>
    public class Document
    {
        private readonly List<Element> _elements = new List<Element>();

        /// <summary>
        /// Добавление элемента в документ
        /// </summary>
        public void Add(Element element)
        {
            _elements.Add(element);
        }

        /// <summary>
        /// Экспорт документа с помощью Visitor
        /// </summary>
        /// <param name="visitor">Посетитель</param>
        /// <returns>Результат преобразования</returns>
        public string Export(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }

            if (visitor is HtmlVisitor htmlVisitor)
                return htmlVisitor.GetResult();

            if (visitor is MarkdownVisitor markdownVisitor)
                return markdownVisitor.GetResult();

            return string.Empty;
        }
    }
}
