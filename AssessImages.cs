namespace Practice;

public class AssessImages
{
    public static void Assess()
    {
        Console.WriteLine("Enter width and height inputs separated by a space:");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int width = int.Parse(inputs[0]);
        int height = int.Parse(inputs[1]);
        if (width > height)
            Console.WriteLine("It's a landscape image");
        else
            Console.WriteLine("It's a portrait");
    }
}