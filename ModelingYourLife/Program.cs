using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingYourLife
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerOneName = "";
            string playerOneChar = "";
            string choiceOne = "";
            string playerTwoName = "";
            string playerTwoChar = "";
            string choiceTwo = "";
            string[] character = { "Barbarian", "Mage", "Assassin" };

            Console.WriteLine("Dungeon Crawler Showdown! \n");

            Console.Write("Player One enter a name: ");
            playerOneName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Player Two enter a name: ");
            playerTwoName = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"{playerOneName}, please choose a number between 1-3.  This will be your character: ");
            choiceOne = Console.ReadLine();

            if (choiceOne == "1")
            {
                playerOneChar = character[0];
                Console.WriteLine($"{playerOneName} has chosen Barbarian.");
                Console.WriteLine();
            }
            else if (choiceOne == "2")
            {
                playerOneChar = character[1];
                Console.WriteLine($"{playerOneName} has chosen Mage.");
                Console.WriteLine();
            }
            else
            {
                playerOneChar = character[2];
                Console.WriteLine($"{playerOneName} has chosen Assassin.");
                Console.WriteLine();
            }

            Console.Write($"{playerTwoName}, please choose a number between 1-3.  This will be your character: ");
            choiceTwo = Console.ReadLine();

            if (choiceTwo == "1")
            {
                playerTwoChar = character[0];
                Console.WriteLine($"{playerTwoName} has chosen Barbarian.");
                Console.WriteLine();
            }
            else if (choiceTwo == "2")
            {
                playerTwoChar = character[1];
                Console.WriteLine($"{playerTwoName} has chosen Mage.");
                Console.WriteLine();
            }
            else
            {
                playerTwoChar = character[2];
                Console.WriteLine($"{playerTwoName} has chosen Assassin.");
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
}
