namespace Practice;

public class OracleConnection(string connectionString, TimeSpan timeout) : DbConnection(connectionString, timeout)
{
    public override void Open()
    {
        Console.WriteLine("Opening Oracle connection");
    }

    public override void Close()
    {
        Console.WriteLine("Closing Oracle connection");
    }
}