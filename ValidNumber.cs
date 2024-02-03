namespace Practice;

public class ValidNumber
{
    public static void Validate()
    {
        Console.WriteLine("Enter a number between 1 and 10");
        var input = int.Parse(Console.ReadLine());
        if (input >= 1 && input <= 10)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}