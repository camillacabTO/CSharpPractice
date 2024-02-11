namespace Practice;

public abstract class DbConnection
{
    private readonly string _connectionString;
    private readonly TimeSpan _timeout;

    public DbConnection(string connectionString, TimeSpan timeout)
    {
        if(string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("The connection string cannot be null or empty.", nameof(connectionString));
        _connectionString = connectionString;
        _timeout = timeout;
    }
    
    public abstract void Open();
    public abstract void Close();
}

public class DBCommand
{
    private readonly DbConnection _dbConnection;
    private readonly string _instruction;

    public DBCommand(DbConnection dbConnection, string instruction)
    {
        if (dbConnection == null)
            throw new ArgumentNullException(nameof(dbConnection), "The database connection cannot be null.");
        if (string.IsNullOrWhiteSpace(instruction))
            throw new ArgumentException("The instruction cannot be null or empty.", nameof(instruction));
        _dbConnection = dbConnection;
        _instruction = instruction;
    }

    public void Execute()
    {
        _dbConnection.Open();
        Console.WriteLine("Executing the instruction: {0}", _instruction);
        _dbConnection.Close();
    }
}