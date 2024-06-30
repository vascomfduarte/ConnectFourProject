using ConsoleApp1.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.GameBoard
{
    internal class FullBoardValidator
    {
        public static bool CheckFull(Board gameBoard)
        {
            for (int row = 0; row < gameBoard.GameBoard.GetLength(0); row++)
            {                
                for (int col = 0; col < gameBoard.GameBoard.GetLength(1); col++)
                {

                    if (gameBoard.GameBoard[row, col] == " ")
                    {
                        return false; // Found an empty cell, the board is not full
                    }
                }
                                    
            }

            return true; // No empty cell, the board is full
        }
    }
}
