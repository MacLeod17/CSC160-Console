using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using KilpackLibrary;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 110;
            int ageInput = Utils.GetConsoleInt($"Please Enter Your Age Between {min} and {max}: ", min, max);
            Console.WriteLine($"Age: {ageInput}");
            Console.WriteLine();

            min = 0; max = 999;
            int areaInput = Utils.GetConsoleInt($"Please Enter Your Area Code Between {min} and {max}: ", min, max);
            Console.WriteLine($"Area Code: {areaInput}");
            Console.WriteLine();

            min = 0; max = 99999;
            int zipInput = Utils.GetConsoleInt($"Please Enter Your Zip Code Between {min} and {max}: ", min, max);
            Console.WriteLine($"Zip Code: {zipInput}");
            Console.WriteLine();

            min = -10; max = 10;
            int intInput = Utils.GetConsoleInt($"Please Enter an Integer Between {min} and {max}: ", min, max);
            Console.WriteLine($"Number: {intInput}");
            Console.WriteLine();

            char charInput = Utils.GetConsoleChar("Please Enter Your First Initial: ");
            Console.WriteLine($"First Initial: {charInput}");
            Console.WriteLine();

            bool boolInput = Utils.GetConsoleBool("I Am Awesome [True/False]: ");
            Console.WriteLine($"Awesome: {boolInput}");
            Console.WriteLine();

            string nameInput = Utils.GetConsoleString("Please Enter Your First Name: ");
            Console.WriteLine($"First Name: {nameInput}");
            Console.WriteLine();

            bool quit = false;
            do
            {
                int input = Utils.GetConsoleMenu("Input your choice: ", new string[] { "Open", "Save", "Print", "Quit" });
                switch(input)
                {
                    case 0:
                        Console.WriteLine("You Chose Open");
                        break;
                    case 1:
                        Console.WriteLine("You Chose Save");
                        break;
                    case 2:
                        Console.WriteLine("You Chose Print");
                        break;
                    case 3:
                        quit = true;
                        break;
                    default:
                        break;
                }

            } while (!quit);
        }
    }
}
