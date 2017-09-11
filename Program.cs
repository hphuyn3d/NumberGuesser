using System;

// Namespace
namespace NumberGuesser
{   // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {
                // Setting random number
                Random rand = new Random();
                int correctNum = rand.Next(1, 10);

                // Setting guess var
                int guess = 0;

                // Ask user to guess a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is incorrect
                while (guess != correctNum)
                {
                    // getting user input
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter in a valid number");
                        continue;

                    }
                    // Converting string to int
                    guess = Int32.Parse(input);

                    // Matching guess to correct number
                    if (guess != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Correct guess message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!");
                
                // Ask to play again
                Console.WriteLine("Play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if (answer == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }
                else
                {
                    return;
                }
                Console.ReadLine();

            }
        }

        /*
         * Setting app information
         */
        static void GetAppInfo()
        {
            // Set app vars (Header)
            string appName = "The Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Hung Huynh";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Writing out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Setting color back to default
            Console.ResetColor();
        }

        /*
         * Greeting user
         */
        static void GreetUser()
        {
            // Asks users name
            Console.WriteLine("What is your name?");

            // Get users input and store it into a string
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game!", inputName);
        }

        /*
         * Print color message
         */
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
