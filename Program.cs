using System;

namespace Practice
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     var mixedStack = new MyStack();
        //     mixedStack.Push(10); // Push an integer
        //     mixedStack.Push("hello"); // Push a string
        //     mixedStack.Push(new { Name = "Alice", Age = 30 });
        //
        //     // Popping items will give them back in reverse order
        //     var person = mixedStack.Pop(); // Need to cast when retrieving non-primitive types
        //     var greeting = (string)mixedStack.Pop(); // Cast to string
        //     var number = (int)mixedStack.Pop(); // No cast needed for primitives
        //     Console.WriteLine("{0} {1} {2}", person, greeting, number);
        // }
        static int Main(string[] args)
        {
            var sqlConnection = new SqlConnection("my sql connection string", TimeSpan.FromSeconds(30));
            var oracleConnection = new OracleConnection("my oracle connection string", TimeSpan.FromSeconds(40));
            var sqlCommand = new DBCommand(sqlConnection, "SELECT * FROM TABLE");
            var oracleCommand = new DBCommand(oracleConnection, "SELECT * FROM TABLE2");
            sqlCommand.Execute();
            oracleCommand.Execute();
            return 0;
        }
    }
}


// var john = new Person();
// var mary = new Person();
// john.FirstName = "John";
// john.LastName = "Smith";
// ValidNumber.Validate();
// MaxNumber.CalculateMax();
// AssessImages.Assess();
// Console.Title = "Test";
// SpeedCamera.checkSpeed();
// CountDivisibleBy3.Count();
// SumInputs.Sum();
// Factorial factorial = new Factorial();
// factorial.DisplayFactorial();
// GuessNumber.MakeAGuess();
// ShowMaxNumber.GetMax();
// FacebookLikes.ShowLikes();
// ReverseString.Reverse("Camila");
// UniqueNumbers.MakeItUnique();
// ConsecutiveNumbers.CheckConsecutives();
// var stopwatch = new Stopwatch();
// stopwatch.Start();
// System.Threading.Thread.Sleep(3000);
// stopwatch.Stop();
// stopwatch.DisplayDuration();
// var post = new Post("My Post", "My post description");
// post.VoteUp();
// post.VoteUp();
// post.VoteDown();
// Console.WriteLine("My votes are {0} {1} {2} {3}", post.Votes, post.Title, post.CreatedAt, post.Description);