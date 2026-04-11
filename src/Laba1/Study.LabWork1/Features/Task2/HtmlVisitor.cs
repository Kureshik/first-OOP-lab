using System.Text;

namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Посетитель, который экспортирует документ в HTML формат
    /// </summary>
    public class HtmlVisitor : IVisitor
    {
        private readonly StringBuilder _sb = new StringBuilder();

        /// <summary>
        /// Возвращает результат преобразования документа в HTML.
        /// </summary>
        /// <returns>Строка, содержащая документ в формате HTML</returns>
        public string GetResult() => _sb.ToString();

        /// <summary>
        /// Посещает элемент Paragraph и добавляет его в HTML формате.
        /// </summary>
        /// <param name="paragraph">Параграф документа</param>
        public void Visit(Paragraph paragraph)
        {
            _sb.AppendLine($"<p>{paragraph.Text}</p>");
        }

        /// <summary>
        /// Посещает элемент Image и добавляет его в HTML формате как тег img.
        /// </summary>
        /// <param name="image">Изображение документа</param>
        public void Visit(Image image)
        {
            _sb.AppendLine($"<img src=\"{image.Src}\" alt=\"{image.Alt}\">");
        }

        /// <summary>
        /// Посещает элемент Table и добавляет его в HTML формате как тег table.
        /// </summary>
        /// <param name="table">Таблица документа</param>
        public void Visit(Table table)
        {
            _sb.AppendLine($"<table border=\"1\">");
            _sb.AppendLine($"  <tr><td colspan=\"{table.Columns}\">Таблица {table.Rows}x{table.Columns}</td></tr>");
            _sb.AppendLine($"</table>");
        }
    }
}
