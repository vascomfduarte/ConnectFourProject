using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Option_BoardSize
    {
        /// <summary>
        /// Enables the selection of a game board size.
        /// </summary>
        public static int Assigner(int selectedOption)
        {
            int boardSize = -1;

            int j = 0;
            while (j < 1)
            {
                // SinglePlayer or MultiPlayer Chooser
                if (selectedOption == 0)
                    break;
                else
                {
                    if (selectedOption == 1 || selectedOption == 2)
                    {
                        boardSize = selectedOption;
                    }
                    break;
                }

                j++;
            }

            return boardSize;
        }
    }
}
