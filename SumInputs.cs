namespace Practice;

public class SumInputs
// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
{
    public static void Sum()
    {
        Console.WriteLine("Enter a number or \"okay \"");
        string input = Console.ReadLine();
        int sum = 0;
        while (input != "okay")
        {
            sum += int.Parse(input);
            input = Console.ReadLine();
        }
        Console.WriteLine($"Sum is: {sum}");
        
    }
}