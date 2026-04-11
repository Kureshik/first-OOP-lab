namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Абстрактный класс Element — базовый для всех элементов документа
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Метод Accept позволяет посетителю (Visitor) выполнить операцию над элементом
        /// </summary>
        /// <param name="visitor">Посетитель</param>
        public abstract void Accept(IVisitor visitor);
    }
}
