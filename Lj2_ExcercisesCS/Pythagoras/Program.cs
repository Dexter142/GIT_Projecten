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
            float userInputA;
            float userInputB;

            float thirdLength;


            // Have the user input both sides of the triangle, only accept float
            do
            {
                Console.WriteLine("Please give me the length of the first side of the triangle");
                userInput = Console.ReadLine();
                Console.WriteLine();
            } while (!float.TryParse(userInput ,out userInputA));

            do
            {
                Console.WriteLine("Please give me the length of the second side of the triangle");
                userInput = Console.ReadLine();
                Console.WriteLine();
            } while (!float.TryParse(userInput, out userInputB));

            // Add a white line and give the input back to the user
            Console.WriteLine();
            Console.WriteLine("The sides of your triangle are: " + userInputA + " and " + userInputB);

            // Calculate the third side of the triangle
            GetLength(userInputA, userInputB);

            // Give the user the result
            Console.WriteLine();
            Console.WriteLine("The length of the third side is: " + Math.Sqrt(GetLength(userInputA, userInputB)));



            float GetLength(float A, float B)
            {
                thirdLength = (A*A) + (B*B);

                return thirdLength;
            }


            Console.ReadLine();
        }
    }
}
