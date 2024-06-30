using ConsoleApp1.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GameBoard
{
    internal class WinValidator
    {
        //public static bool CheckForWinner(Board gameBoard, int boardSize)
        //{
        //    if (boardSize == 1)
        //    {
        //        /*
        //        1  2  3  4  5  6  7   1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16
        //        8  9  10 11 12 13 14  2
        //        15 16 17 18 19 20 21  3
        //        22 23 24 25 26 27 28  4
        //        29 30 31 32 33 34 35  5
        //        36 37 38 39 40 41 42  6
        //                              7
        //                              8
        //                              9
        //                              10
        //                              11
        //                              12
        //                              13
        //                              14  
        //                              15
        //                              16
        //        */

        //        // Horizontal
        //        for (int i = 0; i < gameBoard.GameBoard.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < gameBoard.GameBoard.GetLength(1); j++)
        //            {
        //                int pos = gameBoard.GameBoard.GetLength(0) - i - 1;

        //                // Check Column 1 (index 0)
        //                if (gameBoard.GameBoard[pos, 0] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 0] == gameBoard.GameBoard[pos, 1] && gameBoard.GameBoard[pos, 0] == gameBoard.GameBoard[pos, 2] && gameBoard.GameBoard[pos, 0] == gameBoard.GameBoard[pos, 3])
        //                        return true;
        //                }
        //                // Check Column 2 (index 1)
        //                if (gameBoard.GameBoard[pos, 1] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 1] == gameBoard.GameBoard[pos, 2] && gameBoard.GameBoard[pos, 1] == gameBoard.GameBoard[pos, 3] && gameBoard.GameBoard[pos, 1] == gameBoard.GameBoard[pos, 4])
        //                        return true;
        //                }
        //                // Check Column 3 (index 2)
        //                if (gameBoard.GameBoard[pos, 2] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 2] == gameBoard.GameBoard[pos, 3] && gameBoard.GameBoard[pos, 2] == gameBoard.GameBoard[pos, 4] && gameBoard.GameBoard[pos, 2] == gameBoard.GameBoard[pos, 5])
        //                        return true;
        //                }
        //                // Check Column 4 (index 3)
        //                if (gameBoard.GameBoard[pos, 3] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 2] && gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 1] && gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 0])
        //                        return true;

        //                    if (gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 4] && gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 5] && gameBoard.GameBoard[pos, 3] == gameBoard.GameBoard[pos, 6])
        //                        return true;
        //                }
        //                // Check Column 5 (index 4)
        //                if (gameBoard.GameBoard[pos, 4] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 4] == gameBoard.GameBoard[pos, 3] && gameBoard.GameBoard[pos, 4] == gameBoard.GameBoard[pos, 2] && gameBoard.GameBoard[pos, 4] == gameBoard.GameBoard[pos, 1])
        //                        return true;
        //                }
        //                // Check Column 6 (index 5)
        //                if (gameBoard.GameBoard[pos, 5] != " ")
        //                {
        //                    if (gameBoard.GameBoard[pos, 5] == gameBoard.GameBoard[pos, 4] && gameBoard.GameBoard[pos, 5] == gameBoard.GameBoard[pos, 3] && gameBoard.GameBoard[pos, 5] == gameBoard.GameBoard[pos, 2])
        //                        return true;
        //                }

        //            }
        //        }

        //        // Vertical
        //        for (int i = 0; i < gameBoard.GameBoard.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < gameBoard.GameBoard.GetLength(1); j++)
        //            {
        //                //int pos = gameBoard.GetLength(0) - i - 1;

        //                // Check Row 1 (index 0)
        //                if (gameBoard.GameBoard[0, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[0, j] == gameBoard.GameBoard[1, j] && gameBoard.GameBoard[0, j] == gameBoard.GameBoard[2, j] && gameBoard.GameBoard[0, j] == gameBoard.GameBoard[3, j])
        //                        return true;
        //                }

        //                // Check Row 2 (index 1)
        //                if (gameBoard.GameBoard[1, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[1, j] == gameBoard.GameBoard[2, j] && gameBoard.GameBoard[1, j] == gameBoard.GameBoard[3, j] && gameBoard.GameBoard[1, j] == gameBoard.GameBoard[4, j])
        //                        return true;
        //                }

        //                // Check Row 3 (index 2)
        //                if (gameBoard.GameBoard[2, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[2, j] == gameBoard.GameBoard[3, j] && gameBoard.GameBoard[2, j] == gameBoard.GameBoard[4, j] && gameBoard.GameBoard[2, j] == gameBoard.GameBoard[5, j])
        //                        return true;
        //                }

        //                // Check Row 4 (index 3)
        //                if (gameBoard.GameBoard[3, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[3, j] == gameBoard.GameBoard[2, j] && gameBoard.GameBoard[3, j] == gameBoard.GameBoard[1, j] && gameBoard.GameBoard[3, j] == gameBoard.GameBoard[0, j])
        //                        return true;
        //                }

        //                // Check Row 5 (index 4)
        //                if (gameBoard.GameBoard[4, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[4, j] == gameBoard.GameBoard[3, j] && gameBoard.GameBoard[4, j] == gameBoard.GameBoard[2, j] && gameBoard.GameBoard[4, j] == gameBoard.GameBoard[1, j])
        //                        return true;
        //                }

        //                // Check Row 6 (index 5)
        //                if (gameBoard.GameBoard[5, j] != " ")
        //                {
        //                    if (gameBoard.GameBoard[5, j] == gameBoard.GameBoard[4, j] && gameBoard.GameBoard[5, j] == gameBoard.GameBoard[3, j] && gameBoard.GameBoard[5, j] == gameBoard.GameBoard[2, j])
        //                        return true;
        //                }
        //            }
        //        }

        //        // Diagonal
        //        for (int i = 0; i < gameBoard.GameBoard.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < gameBoard.GameBoard.GetLength(1); j++)
        //            {
        //                int iPos = gameBoard.GameBoard.GetLength(0) - i - 1;
        //                int jPos = gameBoard.GameBoard.GetLength(1) - j - 1;

        //                // Checks [0,0], [1,0], [2,0]//[0,1], [1,1], [2,1]//[0,2], [1,2], [2,2]//[0,3], [1,3], [2,3]
        //                if (gameBoard.GameBoard[i, j] != " " && i < 3 && j < 4)
        //                {
        //                    if (gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i + 1, j + 1] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i + 2, j + 2] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i + 3, j + 3])
        //                        return true;
        //                }

        //                // Checks [0,3], [1,3], [2,3]//[0,4], [1,4], [2,4]//[0,5], [1,5], [2,5]//[0,6], [1,6], [2,6]
        //                if (gameBoard.GameBoard[i, j] != " " && i < 3 && j > 2)
        //                {
        //                    if (gameBoard.GameBoard[i, jPos] == gameBoard.GameBoard[i + 1, j - 1] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i + 2, j - 2] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i + 3, j - 3])
        //                        return true;
        //                }

        //                // Checks [5,0], [4,0], [3,0]//[5,1], [4,1], [3,1]//[5,2], [4,2], [3,2]//[5,3], [4,3], [3,3]
        //                if (gameBoard.GameBoard[i, j] != " " && i > 2 && j < 4)
        //                {
        //                    if (gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 1, j + 1] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 2, j + 2] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 3, j + 3])
        //                        return true;
        //                }

        //                // Checks [5,3], [4,3], [3,3]//[5,4], [4,4], [3,4]//[5,5], [4,5], [3,5]//[5,6], [4,6], [3,6]
        //                if (gameBoard.GameBoard[i, j] != " " && i > 2 && j > 2)
        //                {
        //                    if (gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 1, j - 1] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 2, j - 2] && gameBoard.GameBoard[i, j] == gameBoard.GameBoard[i - 3, j - 3])
        //                        return true;
        //                }

        //            }
        //        }


        //    }
        //    else if (boardSize == 2)
        //    {
        //        /*
        //         * 
        //        for (int i = 0; i < gameBoard.GetLength(0); i++)
        //        {
        //            for (int j = 0; i < gameBoard.GetLength(1); j++)
        //            {
        //                // Horizontal
        //                switch (j)
        //                {
        //                    // Check Pos 1(index 0)
        //                    case 0:

        //                        break;

        //                    // Check Pos 2(index 1)
        //                    case 1:

        //                        break;

        //                    // Check Pos 3(index 2)
        //                    case 2:

        //                        break;

        //                    // Check Pos 4(index 3)
        //                    case 3:
        //                    case 4:
        //                    case 5:
        //                    case 6:
        //                    case 7:
        //                    case 8:
        //                    case 9:
        //                    case 10:
        //                    case 11:
        //                    case 12:
        //                        if (gameBoard[i, 3] != " ")
        //                        {
        //                            if (gameBoard[i, 3] == gameBoard[i, 2] && gameBoard[i, 3] == gameBoard[i, 1] && gameBoard[i, 3] == gameBoard[i, 0])
        //                                return true;

        //                            if (gameBoard[i, 3] == gameBoard[i, 4] && gameBoard[i, 3] == gameBoard[i, 5] && gameBoard[i, 3] == gameBoard[i, 6])
        //                                return true;
        //                        }
        //                        break;

        //                    // Check Pos 5(index 4)
        //                    case 13:

        //                        break;

        //                    // Check Pos 6(index 5)
        //                    case 14:

        //                        break;

        //                    // Check Pos 6(index 5)
        //                    case 15:

        //                        break;

        //                }
        //            }
        //        }

        //        */
        //    }

        //    return false;
        //}
        public static bool CheckWin(Board gameBoard, Player player)
        {
            int rows = gameBoard.GameBoard.GetLength(0);
            int cols = gameBoard.GameBoard.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string symbol = player.Symbol;

                    if (gameBoard.GameBoard[row, col] == symbol)
                    {
                        // Check horizontal win
                        if (col + 3 < cols &&
                            gameBoard.GameBoard[row, col + 1] == symbol &&
                            gameBoard.GameBoard[row, col + 2] == symbol &&
                            gameBoard.GameBoard[row, col + 3] == symbol)
                        {
                            return true;
                        }

                        // Check vertical win
                        if (row + 3 < rows &&
                            gameBoard.GameBoard[row + 1, col] == symbol &&
                            gameBoard.GameBoard[row + 2, col] == symbol &&
                            gameBoard.GameBoard[row + 3, col] == symbol)
                        {
                            return true;
                        }

                        // Check diagonal win (top-left to bottom-right)
                        if (col + 3 < cols && row + 3 < rows &&
                            gameBoard.GameBoard[row + 1, col + 1] == symbol &&
                            gameBoard.GameBoard[row + 2, col + 2] == symbol &&
                            gameBoard.GameBoard[row + 3, col + 3] == symbol)
                        {
                            return true;
                        }

                        // Check diagonal win (bottom-left to top-right)
                        if (col + 3 < cols && row - 3 >= 0 &&
                            gameBoard.GameBoard[row - 1, col + 1] == symbol &&
                            gameBoard.GameBoard[row - 2, col + 2] == symbol &&
                            gameBoard.GameBoard[row - 3, col + 3] == symbol)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
