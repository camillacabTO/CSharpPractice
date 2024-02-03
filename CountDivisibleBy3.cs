namespace Practice;

public class CountDivisibleBy3
{
    public static void Count()
    {
        int count = 0;
        IEnumerable<int> numbers = Enumerable.Range(1, 100);
        foreach (var number in numbers)
        {
            if (number % 3 == 0)
                count++;
        }

        Console.WriteLine($"Count: {count}");
    }
}