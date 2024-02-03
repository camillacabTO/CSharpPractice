namespace Practice;

public class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            (charArray[left], charArray[right]) = (charArray[right], charArray[left]);
            left++;
            right--;
            Console.WriteLine(charArray);
        }
        return new string(charArray);
    }
}