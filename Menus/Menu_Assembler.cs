using ConsoleApp1.ConsoleApps;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    public class Menu_Assembler
    {
        //public static int windowWidth = 120;
        //public static int windowHeight = 31;

        public static int windowWidth = 100;
        public static int windowHeight = 30;

        public static void Menu()
        {
            Console.SetWindowSize(windowWidth, windowHeight);
            ClearConsole.Clear();
            Logo.GameLogo();
            PressToContinue.Press();

            int i = 0;
            while (i < 1)
            {
                switch (InitialMenu.SelectorMenu())
                {
                    // New Game Option
                    case 1:

                        int j = 0;
                        while (j < 1)
                        {
                            int playerAmount = Option_PlayerAmount.Assigner(Menu_PlayerAmount.SelectorMenu());

                            if (playerAmount > 0)
                            {
                                int boardSize = Option_BoardSize.Assigner(Menu_BoardSize.SelectorMenu(playerAmount));

                                if (boardSize > 0)
                                {
                                    Game.GameAssembler.Game(playerAmount, boardSize, windowWidth, windowHeight);
                                }
                                
                                continue;
                            }

                            j++;
                        }

                        // Continue in here in order to cycle through the menu by choice
                        continue;

                    // Game Rules Option
                    case 2:
                        Menu_GameRules.Rules();
                        continue;

                    // Quit Option
                    case 0:
                        break;
                }

                i++;
            }         

        }
    }
}
