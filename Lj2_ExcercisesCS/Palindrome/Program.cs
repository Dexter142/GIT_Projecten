using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Determine whether a word put in by the user is a palindrome.
// A palindrome is a word that is the same read from left to right and right to left.
// For example: Racecar.
// There is a list of Palindromes for you to test on the internet.
// Extra: Determine whether senctences(exlcuding spaces) are palindromes.

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What word do you wish to check?");
            string word = Console.ReadLine();
            //Replace space with empty
            word = word.Replace(" ", String.Empty);
            //Make a character array
            char[] letters = word.ToCharArray();
            Array.Reverse(letters);
            //Make letter array back into a string
            string reversed = new string(letters);
            //Also make sure to check if it actually is the same and that it does not give a shit about caps else it will answer wrongly.
            if(reversed.ToUpper() == word.ToUpper())
            {
            Console.WriteLine("The word is a palindrome");
            }
            else
            {
            Console.WriteLine("This word is in fact NOT a palindrome");
            }
            Console.ReadLine();
        }
    }
}
