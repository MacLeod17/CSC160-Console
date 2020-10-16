using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sound = args.Contains("sound");
            if (sound) Console.Beep(600, 500);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            bool quitApp = false;
            do
            {
                Console.Clear();
                quitApp = PlayGame(sound);
            } while (!quitApp);
        }

        static bool PlayGame(bool sound)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to the Number Guessing Game!");

            int max = GetConsoleInt("Please enter the maximum value for the guessing game: ");
            int number = random.Next(1, max);
            int guessesLeft = 5;
            bool quitGame = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine($"Guesses left: { guessesLeft }");
                int guess = GetConsoleInt("Enter Guess: ");
                if (sound) Console.Beep(600, 500);
                guessesLeft--;
                if (guess == number)
                {
                    Console.WriteLine("Correct! You win the game!");
                    quitGame = true;
                }
                else if (guessesLeft == 0 && guess != number)
                {
                    Console.WriteLine("Incorrect. I'm sorry, you've used up all your guesses. Game Over");
                    quitGame = true;
                }
                else
                {
                    if (guess < number) Console.WriteLine("Too low, try again!");
                    else if (guess > number) Console.WriteLine("Too high, try again!");
                }
            } while (!quitGame);

            Console.WriteLine();
            Console.Write("Would you like to play another game? (yes/no): ");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes" || playAgain == "y") return false;
            else if (playAgain == "no" || playAgain == "n") return true;
            return true;
        }

        static int GetConsoleInt(string prompt)
        {
            int number;
            bool quit = false;
            do
            {
                Console.Write(prompt);
                string entry = Console.ReadLine();
                bool success = int.TryParse(entry, out number);
                if (!success)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Entry");
                }
                else
                {
                    //Console.WriteLine(number);
                    quit = true;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
            } while (!quit);

            return number;
        }
    }
}
