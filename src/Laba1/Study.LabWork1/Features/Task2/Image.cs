namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Представляет изображение в документе.
    /// </summary>
    public class Image : Element
    {
        /// <summary>
        /// Путь или URL к изображению.
        /// </summary>
        public string Src { get; }

        /// <summary>
        /// Альтернативный текст изображения.
        /// </summary>
        public string Alt { get; }

        /// <summary>
        /// Создаёт новое изображение.
        /// </summary>
        /// <param name="src">Путь или URL к изображению</param>
        /// <param name="alt">Альтернативный текст (по умолчанию пустая строка)</param>
        public Image(string src, string alt = "")
        {
            Src = src ?? string.Empty;
            Alt = alt ?? string.Empty;
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
