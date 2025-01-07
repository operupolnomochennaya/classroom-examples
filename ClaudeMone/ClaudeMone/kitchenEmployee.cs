namespace ClaudeMone;

public class kitchenEmployee : restaurantClaudeMonetEmployee
{
    public override void PerformDuty()
    {
        Console.WriteLine($"{Name} готовит блюда.");
    }
    public virtual void EmployeeDo()
    {
        Console.WriteLine($"{Name} этим занимается.");
    }
}
public class Senya : kitchenEmployee
{
    public override void EmployeeDo()
    {
        Console.WriteLine($"{Name} крадёт продукты с кухни.");
    }
}
public class Fedya : kitchenEmployee
{
    public override void EmployeeDo()
    {
        Console.WriteLine($"{Name} ржёт с {Name} с {Name}.");
    }
}

public class Oguzok : kitchenEmployee
{
    public override void EmployeeDo()
    {
        Console.WriteLine($"{Name} снимает наклейки с бананов.");
    }
}

public class Chef : kitchenEmployee
{
    public override void EmployeeDo()
    {
        Console.WriteLine($"{Name} орёт на {Name}.");
    }
}
