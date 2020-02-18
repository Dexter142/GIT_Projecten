using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment:
// Program a game of rock-paper-scissors against the computer.
// Extra: 2 player game.
// Keep it clean.

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
        Random rnd = new Random();

            int choice;           

            string userInput;

            int randomChoise = rnd.Next(1,4);

            //making a decision
            Console.WriteLine("Welcome to rock paper scissors");
            Console.WriteLine("press 1 for rock");
            Console.WriteLine("press 2 for scissors");
            Console.WriteLine("press 3 for paper");
            do
            {
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out choice));

            //when you choose rock
            if (choice == 1&& randomChoise ==1)
            {
                Console.WriteLine("the bot had rock");
                Console.WriteLine("even game");
            }
            if (choice == 1 && randomChoise == 2)
            {
                Console.WriteLine("the bot had scissors");
                Console.WriteLine("you have won");
            }
            if (choice == 1 && randomChoise == 3)
            {
                Console.WriteLine("the bot had paper");
                Console.WriteLine("you have lost");

            }
            //when you choose scissors
            if (choice == 2 && randomChoise == 1)
            {
                Console.WriteLine("the bot had rock");
                Console.WriteLine("you have lost");
            }
            if (choice == 2 && randomChoise == 2)
            {
                Console.WriteLine("the bot had scissors");
                Console.WriteLine("even game");
            }
            if (choice == 2 && randomChoise == 3)
            {
                Console.WriteLine("the bot had paper");
                Console.WriteLine("you have won");

            }
            //when you choise paper
            if (choice == 3 && randomChoise == 1)
            {
                Console.WriteLine("the bot had rock");
                Console.WriteLine("you have won");
            }
            if (choice == 3 && randomChoise == 2)
            {
                Console.WriteLine("the bot had scissors");
                Console.WriteLine("you have lost");
            }
            if (choice == 3 && randomChoise == 3)
            {
                Console.WriteLine("the bot had paper");
                Console.WriteLine("even game");
            }

            Console.ReadLine();
        }
    }
}
