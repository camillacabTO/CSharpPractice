namespace Practice;

public class MaxNumber
{
    public static void CalculateMax()
    {
        Console.WriteLine("Enter two inputs separated by a space:");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int input1 = int.Parse(inputs[0]);
        int input2 = int.Parse(inputs[1]);
        // Console.WriteLine($"The highest value is: {int.Max(input1, input2)}");
    }
}