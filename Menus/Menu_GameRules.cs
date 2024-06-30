using ConsoleApp1.ConsoleApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Menu_GameRules
    {
        public static void Rules()
        {
            ClearMenu.Clear();

            Logo.GameLogo();

            // Menu
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" 1. New Game   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" 2. Game Rules");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t > ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tRules for Align Four ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n 0. Quit ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t Align Four is a game based on Connect 4, it is usually played on a grid with six rows and ");
            Console.WriteLine("\t\t\t seven columns. Two players take turns dropping their colored game pieces into the columns.");
            Console.WriteLine("\n\t\t\t On your turn, choose a column to drop your disc into. It will fall to the lowest available");
            Console.WriteLine("\t\t\t space in that column. If all the spaces are filled and no player has connected four discs,");
            Console.WriteLine("\t\t\t the game ends in a tie.");
            Console.WriteLine("\n\t\t\t In Align Four, the objective is to be the first player to form a line of four of their ");
            Console.WriteLine("\t\t\t colored discs in any direction: vertically, horizontally, or diagonally.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n >");
            Console.ResetColor();
            Console.Write(" Press a key to go back to Menu. ");
            Console.ReadLine();

        }

    }
}
