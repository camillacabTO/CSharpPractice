namespace Practice;

public class SpeedCamera
{
    public static void checkSpeed()
    {
        Console.WriteLine("Enter speed limit");
        var speedLimit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter car speed");
        var carSpeed = int.Parse(Console.ReadLine());
        if (carSpeed < speedLimit)
        {
            Console.WriteLine("Okay. Legal speed");
        }
        else
        {
            var demeritPoints = (carSpeed - speedLimit) / 5;
            Console.WriteLine($"Demerit points {demeritPoints}");
            if (demeritPoints > 12)
                Console.WriteLine("License Suspended");
        }
    }
}