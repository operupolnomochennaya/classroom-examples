namespace ClaudeMone;

public abstract class RestaurantEmployeeReport : IEmployeeReport
{
    protected string Name { get; set; }

    public virtual void ReportActivity()
    {
        Console.WriteLine($"{Name} сообщает о своей деятельности.");
    }
}