using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilpackLibrary
{
    public static class Utils
    {
        public static int GetConsoleInt(string prompt, int min, int max)
        {
            int number = 0;

            bool success = false;
            do
            {
                Console.Write(prompt);
                bool valid = int.TryParse(Console.ReadLine(), out number);
                success = valid && (number >= min && number <= max);
            } while (!success);

            return number;
        }

        public static bool GetConsoleBool(string prompt)
        {
            bool boolInput = false;

            bool success = false;
            do
            {
                Console.Write(prompt);
                bool valid = bool.TryParse(Console.ReadLine(), out boolInput);
                success = valid;
            } while (!success);

            return boolInput;
        }

        public static char GetConsoleChar(string prompt)
        {
            char charInput = ' ';

            bool success = false;
            do
            {
                Console.Write(prompt);
                bool valid = char.TryParse(Console.ReadLine(), out charInput);
                success = valid;
            } while (!success);

            return charInput;
        }

        public static string GetConsoleString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int GetConsoleMenu(string message, string[] items)
        {
            for (int i=0; i < items.Length; i++)
            {
                Console.WriteLine($"{i} - {items[i]}");
            }
            return GetConsoleInt(message, 0, items.Length);
        }

        static Random random = new Random();
        public static int GetRandom(this int max, int min = 0)
        {
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
            return random.Next(min, max+1);
        }
    }
}
