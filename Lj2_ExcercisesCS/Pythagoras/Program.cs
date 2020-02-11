using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// When a user gives the length of 2 sides of a right angled triangle, determine the length of the third.
// Keep it clean.

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            // These integers are for the output
            int userInputA;
            int userInputB;


            do
            {
                Console.WriteLine("Please give me the length of the first side of the triangle");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput ,out userInputA));

            do
            {
                Console.WriteLine("Please give me the length of the second side of the triangle");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out userInputB));

            Console.WriteLine("The sides of your triangle are: " + userInputA + " and " + userInputB);


            Console.ReadLine();
        }
    }
}
