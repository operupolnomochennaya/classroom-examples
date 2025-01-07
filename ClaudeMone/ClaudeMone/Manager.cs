namespace ClaudeMone;

public class Manager : restaurantClaudeMonetEmployee
{
    public override void PerformDuty()
    {
       Console.WriteLine($"{Name} управляет рестораном.");
    }
}