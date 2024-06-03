using Task3;

class Program
{
    static void Main(string[] args)
    {
        Accountant accountant = new Accountant();
        
        // // Приклад перевірки премії для менеджера
        // Post worker = Post.Менеджер;
        // int workedHours = 170;
        //
        // bool bonus = accountant.AskForBonus(worker, workedHours);
        // Console.WriteLine($"Співробітник {worker} відпрацював {workedHours}." +
        //                   $"Премія: {bonus}");
        
        // Введення даних від користувача
        Console.WriteLine("Введіть посаду (Менеджер, Розробник, QAІнженер, Дизайнер): ");
        string inputPost = Console.ReadLine();
        Console.WriteLine("Введіть кількість відпрацьованих годин: ");
        if (int.TryParse(Console.ReadLine(), out int inputHours) && Enum.TryParse(inputPost, out Post inputWorker))
        {
            bool userBonus = accountant.AskForBonus(inputWorker, inputHours);
            Console.WriteLine($"Співробітник {inputWorker} відпрацював {inputHours} годин. Премія: {userBonus}");
        }
        else
        {
            Console.WriteLine("Введено некоректні дані.");
        }
    }
}

