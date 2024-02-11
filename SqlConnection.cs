namespace Practice;

public class SqlConnection(string connectionString, TimeSpan timeout) : DbConnection(connectionString, timeout)
// primary construction, new with C#12
{
    public override void Open()
    {
        Console.WriteLine("Opening SQL connection");
    }

    public override void Close()
    {
        Console.WriteLine("Closing SQL connection");
    }
}