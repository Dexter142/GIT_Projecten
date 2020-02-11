using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Ask the user for a number.
// Determine whether the input is even or odd.
// Give the output back.
// Make sure code and user interaction is clean.

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputInt;


            // Ask the user for input, only accept an integer number
            do
            {
                Console.WriteLine("Please input a number here.");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userInputInt));

            // Add a white line and give the user their input back
            Console.WriteLine();
            Console.WriteLine("Your number is: " + userInputInt);
            Console.WriteLine();

            GetEvenOrOdd(userInputInt);

            // This is the method to check if it is an even or odd number
            void GetEvenOrOdd(int number)
            {
                int moduloResult;
                moduloResult = userInputInt % 2;

                // If the result is 0, it is an even number
                if (moduloResult == 0)
                {
                    Console.WriteLine("This number is an even number");
                }
                // If the result is 1, it is an odd number
                else if (moduloResult == 1)
                {
                    Console.WriteLine("This number is an odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
