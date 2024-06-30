using ConsoleApp1.ConsoleApps;
using ConsoleApp1.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Menu_BoardSize
    {
        /// <summary>
        /// Game Type and Board Chooser Menu
        /// </summary>
        /// <returns></returns>
        public static int SelectorMenu(int playerAmount)
        {
            // Menu with 3 Options
            int optionAmount = 3;
            int selectedOption = -1;

            while (selectedOption < 0)
            {
                ClearMenu.Clear();

                Logo.GameLogo();

                //Menu
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 1. New Game");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t > ");

                // Two possible menus, depending on previous selections
                if (playerAmount == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\t1. Play against the computer");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t1. Classic Board (6x7)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" 2. Game Rules");
                    Console.Write("\t\t2. Play with a friend");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t2. XL Board (16x16)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n 0. Quit");
                    Console.Write("\t\t0. Back");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\t\t0. Back\n\n");
                }
                else if (playerAmount == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\t1. Play against the computer");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t1. Classic Board (6x7)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(" 2. Game Rules");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\t\t2. Play with a friend");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t\t > ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t2. XL Board (12x12)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\n 0. Quit");
                    Console.Write("\t\t0. Back");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\t\t0. Back\n\n");
                }

                OptionSelector.SelectorMenu();
                                
                selectedOption = InputOptionValidator.ValidateOption(optionAmount);
            }

            return selectedOption;
        }
    }
}
