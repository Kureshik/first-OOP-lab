namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Представляет таблицу в документе.
    /// </summary>
    public class Table : Element
    {
        /// <summary>
        /// Количество строк в таблице.
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// Количество столбцов в таблице.
        /// </summary>
        public int Columns { get; }

        /// <summary>
        /// Создаёт новую таблицу с указанным количеством строк и столбцов.
        /// </summary>
        /// <param name="rows">Количество строк в таблице</param>
        /// <param name="columns">Количество столбцов в таблице</param>
        public Table(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        /// <summary>
        /// Принимает посетителя и делегирует ему обработку текущего элемента таблицы.
        /// </summary>
        /// <param name="visitor">Посетитель</param>
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
