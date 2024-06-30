using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.InputValidators;

namespace ConsoleApp1.Menus
{
    internal static class InitialMenu
    {
        /// <summary>
        /// Shows the initial menu for the game and allows for the player to navigate throw the aditional menus.
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
                Console.WriteLine(" 1. New Game");
                Console.WriteLine(" 2. Game Rules");
                Console.WriteLine("\n 0. Quit\n");

                OptionSelector.SelectorMenu();

                selectedOption = InputOptionValidator.ValidateOption(optionAmount);
            }

            return selectedOption;

        }
        
    }
}
