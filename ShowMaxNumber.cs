namespace Practice;

public class ShowMaxNumber
{
    public static void GetMax()
    {
        Console.WriteLine("Enter a few numbers separated by a comma");
        string[] stringNumbers = Console.ReadLine().Split(",");
        var intNumbers = new List<int>();
        foreach (var num in stringNumbers)
        {
            intNumbers.Add(int.Parse(num));
        }
        Console.WriteLine($"The maximum of the numbers is: {intNumbers.Max()}");
    }
}