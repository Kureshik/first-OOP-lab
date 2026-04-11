using System.Text;

namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Посетитель, который экспортирует документ в Markdown формат
    /// </summary>
    public class MarkdownVisitor : IVisitor
    {
        private readonly StringBuilder _sb = new StringBuilder();

        /// <summary>
        /// Возвращает результат преобразования документа в Markdown.
        /// </summary>
        /// <returns>Строка, содержащая документ в формате Markdown</returns>
        public string GetResult() => _sb.ToString();

        /// <summary>
        /// Посещает элемент Paragraph и добавляет его в Markdown формате.
        /// </summary>
        /// <param name="paragraph">Параграф документа</param>
        public void Visit(Paragraph paragraph)
        {
            _sb.AppendLine(paragraph.Text);
            _sb.AppendLine();
        }

        /// <summary>
        /// Посещает элемент Image и добавляет его в Markdown формате как изображение.
        /// </summary>
        /// <param name="image">Изображение документа</param>
        public void Visit(Image image)
        {
            _sb.AppendLine($"![{image.Alt}]({image.Src})");
        }

        /// <summary>
        /// Посещает элемент Table и добавляет его в Markdown формате как полноценную таблицу.
        /// </summary>
        /// <param name="table">Таблица документа</param>
        public void Visit(Table table)
        {
            _sb.AppendLine($"**Таблица {table.Rows}x{table.Columns}**");
            _sb.AppendLine();

            // Шапка
            _sb.Append("| ");
            for (int i = 1; i <= table.Columns; i++)
            {
                _sb.Append($"Колонка {i} | ");
            }
            _sb.AppendLine();

            // Разделитель
            _sb.Append("|");
            for (int i = 1; i <= table.Columns; i++)
            {
                _sb.Append(" --- |");
            }
            _sb.AppendLine();

            // Строки таблицы
            for (int row = 1; row <= table.Rows; row++)
            {
                _sb.Append("| ");
                for (int col = 1; col <= table.Columns; col++)
                {
                    _sb.Append($"({row}, {col}) | ");
                }
                _sb.AppendLine();
            }

            _sb.AppendLine();
        }
    }
}
