using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Program the game hangman. Make sure there are some words(5 or so) to guess and these are publicly acceptable...
// You do not have to make ASCII art.
// Keep a list visible for the user with used and incorrect letters.
// Make sure the player can see how many letters are in the word, which letters are guessed and on which position these are.

namespace Hangman
{
    class Program
    {


        static void Main(string[] args)
        {
<<<<<<< HEAD
            //test bericht
=======

            Console.WriteLine("Welkom bij Galgje !!!!!!!!!!");
            string[] listwords = new string[10];
            listwords[0] = "slapen";
            listwords[1] = "schaap";
            listwords[2] = "computer";
            listwords[3] = "corona";
            listwords[4] = "water";
            listwords[5] = "frikandel";
            listwords[6] = "zwart";
            listwords[7] = "verzenden";
            listwords[8] = "kleding";
            listwords[9] = "school";

            Random randGen = new Random();

            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Raad het woord: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                
            }
>>>>>>> Dev_Dexter
        }
    }
}

















