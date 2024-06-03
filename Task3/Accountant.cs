namespace Task3;

public class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        // Метод для перевірки, чи належить співробітнику премія
        int requiredHours = (int)worker;
        return hours > requiredHours;
    }
}