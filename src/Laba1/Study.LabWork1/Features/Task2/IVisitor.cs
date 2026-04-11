namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Интерфейс Visitor (Посетитель).
    /// Определяет набор операций, которые могут быть выполнены над элементами документа.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Посещает элемент типа Paragraph.
        /// </summary>
        /// <param name="paragraph">Параграф документа</param>
        void Visit(Paragraph paragraph);

        /// <summary>
        /// Посещает элемент типа Image.
        /// </summary>
        /// <param name="image">Изображение документа</param>
        void Visit(Image image);

        /// <summary>
        /// Посещает элемент типа Table.
        /// </summary>
        /// <param name="table">Таблица документа</param>
        void Visit(Table table);
    }
}
