namespace ClaudeMone;

public interface Customer : IEmployeeReport
{
    protected string Name { get; set; }

    public void ReportActivity()
    {
        Console.WriteLine($"{Name} сообщает о своём опыте в ресторане.");
    }
}