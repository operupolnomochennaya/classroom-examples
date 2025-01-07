namespace ClaudeMone;

public class Owner : restaurantClaudeMonetEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine($"{Name} владеет рестораном.");
    }
}