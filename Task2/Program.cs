using Task2;

class Program
{
    static void Main()
    {
        // Введення рядка користувачем
        Console.WriteLine("Введіть рядок: ");
        string userInput = Console.ReadLine();
        
        // Вибір кольору користувачем
        Console.WriteLine("Виберіть колір (введіть число): ");
        foreach (var color in Enum.GetValues(typeof(ConsoleColorEnum)))
        {
            Console.WriteLine($"{(int)color} - {color}");
        }

        if (int.TryParse(Console.ReadLine(), out int colorChoice))
        {
            // Виклик методу Print для виведення рядка з вибраним кольором
            Printer.Print(userInput, colorChoice);
        }
        else
        {
            Console.WriteLine("Введено некоректне значення.");
        }
    }
}