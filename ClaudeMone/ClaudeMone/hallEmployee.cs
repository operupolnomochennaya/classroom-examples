namespace ClaudeMone;

public class hallEmployee : restaurantClaudeMonetEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine($"{Name} обслуживает клиентов в зале.");
    }
}