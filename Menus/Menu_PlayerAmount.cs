using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.InputValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Menu_PlayerAmount
    {
        /// <summary>
        /// SinglePlayer and MultiPlayer option chooser.
        /// </summary>
        /// <returns></returns>
        public static int SelectorMenu()
        {
            // Menu with 3 Options
            int optionAmount = 3;
            int selectedOption = -1;

            while (selectedOption < 0)
            {
                ClearMenu.Clear();

                Logo.GameLogo();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 1. New Game");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t > ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t1. Play against the computer");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" 2. Game Rules");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t2. Play with a friend");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("\n 0. Quit");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\t\t0. Back\n\n");

                OptionSelector.SelectorMenu();

                selectedOption = InputOptionValidator.ValidateOption(optionAmount);
            }

            return selectedOption;
        }
    }
}
