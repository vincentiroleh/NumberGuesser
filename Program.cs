using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function

            GreetUser(); // Run GreetUser function      

            while (true)
            {
                // int correct number
                // int correctNumber = 7;

                // create a new Random object
                Random random = new Random();

                // int correct number
                int correctNumber = random.Next(1, 10);

                // int guess var
                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users guess input
                    string guessInput = Console.ReadLine();

                    // make sure its a number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");                       

                        continue;
                    }

                    // cast to int and put in guess var
                    guess = Convert.ToInt32(guessInput);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // print success message
                PrintColorMessage(ConsoleColor.Yellow, "You're CORRECT!!!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vincent Iroleh";

            // change text color;
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine($"{appName} version {appVersion} by {appAuthor}");

            // reset text color to default
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user name input
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, let's play a game...");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color;
            Console.ForegroundColor = color;

            // tell user its the not a number
            Console.WriteLine(message);

            // reset text color to default
            Console.ResetColor();
        }
    }
}
