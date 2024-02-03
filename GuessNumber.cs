namespace Practice;

public class GuessNumber
{
    public static void MakeAGuess()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        int attemps = 4;
        int guess;
        
        while(attemps > 0)
        {
            Console.WriteLine("Guess the number:");
            guess = int.Parse(Console.ReadLine());
            attemps--;
            if (randomNumber == guess)
            {
                Console.WriteLine("You won!");
                return;
            }
        }
        Console.WriteLine("You lost!");
    }
}