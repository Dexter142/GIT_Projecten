using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Determine whether a year put in by the user is a leap year or not.
// There are rules for determining if a year is a leap year or not.
// Give the result back to the user.
// Keep it clean.

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year do you wish to check?");
            string year = Console.ReadLine();
            int.TryParse(year, out int result);
            if (result % 4 == 0)
            {
            Console.WriteLine("{0} is a leapyear", year);
            }
            else
            {
            Console.WriteLine("The year {0} is in fact NOT a leapyear!", year);
            }
            Console.ReadLine();
        }
    }
}
