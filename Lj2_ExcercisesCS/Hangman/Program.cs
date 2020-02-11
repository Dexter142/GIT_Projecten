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
        

             Random rnd = new Random();
             List<string> words = new List<string>();

            void Main(string[] args)
            {
                LoadWords();
                Hangman();
            }

             void LoadWords()
            {
                words.Add("frikandelbroodje");
                words.Add("Auto");
                words.Add("Hond");
                words.Add("Computer");
                words.Add("Advocaat");
                words.Add("Verzenden");
                words.Add("Grofweg");
                
            }

            void Hangman()
            {
                //creates a string variable and stores a random word from the array 
                string word = words[rnd.Next(words.Count)].ToUpper();

                //puts the string into seperate characters and stores them in an array called letters
                char[] letters = word.ToCharArray();

                //creates a char array called empty for the default display when no letters have been guessed
                //will end up looking like this _ _ _ _
                char[] board = new string('_', word.Length).ToCharArray();

                string letterChoice = "";
                while (String.Join("", board) != word && letterChoice != "QUIT")
                {
                    DisplayBoard(board);
                    Console.Write("Your guess: (or \"quit\" to end) ");

                    //stores the letter the user enters to a string variable called letterChoice
                    letterChoice = Console.ReadLine().Trim().ToUpper();
                    if (letterChoice.Length > 0 && letterChoice != "QUIT")
                    {
                        char letter = letterChoice.ToCharArray()[0];
                        letterChoice = letterChoice.Substring(0, 1);
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (letters[i] == letter)
                            {
                                board[i] = letter;
                            }
                        }
                    }
                }
                if (letterChoice != "QUIT")
                {
                    DisplayBoard(board);
                    Console.WriteLine("You got my word!");
                }
                else
                {
                    Console.WriteLine("Maybe next time!");
                }
                Console.WriteLine("Press Enter to quit...");
                Console.ReadLine();
            }

            void DisplayBoard(char[] board)
            {
                Console.Clear();
                Console.WriteLine("Choose your letters and lets play!");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
                Console.WriteLine("\t" + String.Join(" ", board));
                Console.WriteLine("");
            }

        }
    }

















