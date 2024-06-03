class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть вашу дату народження (у форматі РРРР-ММ-ДД)");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            // Якщо день народження в цьому році вже минув, додаємо 1 рік
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int daysUntilNextBirthday = (nextBirthday - today).Days;
            
            Console.WriteLine($"До вашого наступного дня народження залишилось {daysUntilNextBirthday} днів.");
        }
        else
        {
            Console.WriteLine("Некоректний формат дати. Будь ласка, спробуйте ще раз.");
        }
    }
}