using System;

namespace NumberGuesser
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {

            GetAppInfo(); //run the function to get program details

            GreetUser(); //as user for their name

            

            while (true)
            {

                //set correct number
                //int correctNum = 7;

                //create new Random object
                Random random = new Random();

                int correctNum = random.Next(1, 10);

                //initialize guess number
                int guessNum = 0;

                //ask user for a guess
                Console.WriteLine("Please guess a number from 1 to 10.");

                //while guess is not correct
                while (guessNum != correctNum)
                {
                    //get user input
                    string userGuess = Console.ReadLine();

                    //make sure user input is a number
                    if (!int.TryParse(userGuess, out guessNum))
                    {
                        //print warning message
                        PrintColorMessage(ConsoleColor.Yellow, "Sorry friend! Please use an actual number.");

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guessNum
                    guessNum = Int32.Parse(userGuess);

                    //match userGuess to correctNum
                    if (guessNum != correctNum)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please guess again!");
                    }
                }

                //output success message
                PrintColorMessage(ConsoleColor.Green, "Success! That is the correct number!");

                //ask to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                //get answer
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

        //get app info
        static void GetAppInfo()
        {
            //set app varaibles
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Maria Brock";

            //change text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //write out app info
            Console.WriteLine("{0}: Version {1}, by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }

        //say hello to player
        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("Welcome, Traveler, what is your name?");

            //get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello, {0}! Let's play a game.", userName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //tell user the number is wrong
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
