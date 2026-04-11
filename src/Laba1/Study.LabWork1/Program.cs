using Study.LabWork1.Shared.Services;

namespace Study.LabWork1;

/// <summary>
/// Начальная точка входа
/// </summary>
public static class Program
{
    /// <summary>
    /// Номер выполняемой задачи
    /// </summary>
    private const int RUN_TASK_NUMBER = 1;

    /// <summary>
    /// Старт программы
    /// </summary>
    public static void Main()
    {
        var service = new RunService();

        Console.Write("Enter task number: ");
        int run_task_number = int.Parse(Console.ReadLine());

        switch (run_task_number)
        {
            case 1:
                service.RunTask1();
                break;
            case 2:
                service.RunTask2();
                break;
            case 3:
                service.RunTask3();
                break;
            default:
                throw new NotSupportedException();
        }
    }
}
