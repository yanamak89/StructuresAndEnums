namespace Task2;

public static class Printer
{
    // Метод для виведення рядка заданим кольором

    public static void Print(string stroka, int color)
    {
        if (Enum.IsDefined(typeof(ConsoleColorEnum), color))
        {
            ConsoleColor chosenColor = (ConsoleColor)color;
            Console.ForegroundColor = chosenColor;
            Console.WriteLine(stroka);
            Console.ResetColor();// Повернення стандартного кольору
        }
        else
        {
            Console.WriteLine("Неправильний вибір кольору");
        }
    }
}