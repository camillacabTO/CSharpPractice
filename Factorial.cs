namespace Practice;

public class Factorial
{
    private int CalculateFactorial(int number)
    {
        if (number != 0)
            return number * CalculateFactorial(number - 1);
        return 1;
    }
    
    public void DisplayFactorial()
    {
        Console.WriteLine("Enter a number to calculate Factorial:");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial of {input} is {CalculateFactorial(input)}");
    }
}