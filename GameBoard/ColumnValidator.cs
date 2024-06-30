using ConsoleApp1.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GameBoard
{
    internal class ColumnValidator
    {
        public static bool CheckFull(int playPosition, Board gameBoard)
        {
            if (gameBoard.GameBoard[0,playPosition] != " ") 
            {                
                return true;
            }

            return false;
        }
    }
}
