namespace ClaudeMone;

public class Provider : restaurantClaudeMonetEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine($"{Name} поставляет продукты в ресторан.");
    }
}