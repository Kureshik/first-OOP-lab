namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Представляет параграф текста в документе.
    /// </summary>
    public class Paragraph : Element
    {
        /// <summary>
        /// Текст параграфа.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Создаёт новый параграф с указанным текстом.
        /// </summary>
        /// <param name="text">Текст параграфа</param>
        public Paragraph(string text)
        {
            Text = text ?? string.Empty;
        }

        /// <summary>
        /// Принимает посетителя и делегирует ему обработку текущего элемента.
        /// </summary>
        /// <param name="visitor">Посетитель</param>
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
