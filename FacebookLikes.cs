namespace Practice;

public class FacebookLikes
{
    public static void ShowLikes()
    {
        string input;
        var friends = new List<string>();
        
        do
        {
            Console.WriteLine("Enter the name of one of your friends:");
            input = Console.ReadLine();
            if(!String.IsNullOrEmpty(input))
                friends.Add(input);
        } while (!String.IsNullOrEmpty(input));

        if (friends.Count > 2)
        {
            Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count - 2} others like your post.");
        }
        else if (friends.Count == 2)
        {
            Console.WriteLine($"{friends[0]} and {friends[1]} like your post.");
        }
        else if (friends.Count == 1)
        {
            Console.WriteLine($"{friends[0]} likes your post.");
        }
    }
}