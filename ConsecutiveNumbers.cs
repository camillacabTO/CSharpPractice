namespace Practice;

public class ConsecutiveNumbers
{
    public static void CheckConsecutives()
    {
        Console.WriteLine("Enter a few numbers separated by a hyphen:");
        string numbers = Console.ReadLine();
        bool isConsecutive = true;
        var numbersArray = numbers.Split('-').Select(int.Parse).ToArray();
        Array.Sort(numbersArray);
        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            if ((numbersArray[i] + 1 != numbersArray[i + 1]) && (numbersArray[i] - 1 != numbersArray[i + 1]))
            {
                isConsecutive = false;
                break;
            }
        }
        Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
    }
}