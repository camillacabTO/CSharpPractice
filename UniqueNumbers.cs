namespace Practice;

public class UniqueNumbers
{
// 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    public static void MakeItUnique()
    {
        string input;
        char[] numbers;
        bool unique = false;
        
        while(unique != true)
        {
            Console.WriteLine("Enter 5 unique numbers: ");
            input = Console.ReadLine();
            numbers = input.ToCharArray();
            unique = numbers.Distinct().Count() == numbers.Length;
            if (unique)
            {
                Array.Sort(numbers);
                Console.WriteLine($"Your unique numbers are: {String.Join("", numbers)}");
                break;
            }
        }
    }

}