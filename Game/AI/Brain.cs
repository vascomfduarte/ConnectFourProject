using ConsoleApp1.GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.AI
{
    public class Brain
    {
        public Brain(Board gameBoard, Player player)
        {
        }

        public static bool FirstPlay(Board gameBoard)
        {
            int cols = gameBoard.GameBoard.GetLength(0);

            // If first to play, play pos 4
            int blankSpaces = 0;
            for (int r = 5; r >= 5; r--)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (gameBoard.GameBoard[r, c] == " ")
                    {
                        blankSpaces++;
                    }

                    if (blankSpaces == 6)
                    {
                        return true;
                    }
                }
            }

            return false;
        }       

        public static int IsWinningMove(Board gameBoard, string symbol)
        {
            int cols = gameBoard.GameBoard.GetLength(0);
            int consecutiveCount = 0;

            // Check vertical
            for (int c = 0; c <= cols; c++)
            {
                for (int r = 5; r >= 0; r--)
                {
                    if (gameBoard.GameBoard[3, c] != symbol && gameBoard.GameBoard[3, c] != " ")
                    {
                        break;
                    }
                    else if (gameBoard.GameBoard[r, c] == symbol)
                    {
                        consecutiveCount++;
                                                
                        if (consecutiveCount == 3)
                        {
                            if (gameBoard.GameBoard[r - 1, c] != " " || gameBoard.GameBoard[r + 1, c] != symbol)
                            {
                                consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                                break;
                            }

                            return c;
                        }
                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }

            consecutiveCount = 0; // Reset the count for the next check.

            // Check horizontal
            for (int r = 5; r >= 0; r--)
            {
                for (int c = 0; c <= cols; c++)
                {
                    if (gameBoard.GameBoard[r, 3] != symbol)
                    {
                        break;
                    }
                    else if (gameBoard.GameBoard[r, c] == symbol)
                    {
                        consecutiveCount++;

                        if (consecutiveCount == 3)
                        {
                            if (c + 1 < cols && gameBoard.GameBoard[r, c + 1] == " ")
                            {
                                return c + 1;
                            }
                            else if (c - 3 > 0 && gameBoard.GameBoard[r, c - 3] == " ")
                            {
                                return c - 3;
                            }
                        }
                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }

            //    // Diagonal Play (top-left to bottom-right)
            //    if (col + 3 <= cols && row + 3 <= rows &&
            //        gameBoard.GameBoard[row + 3, col + 3] == symbol &&
            //        gameBoard.GameBoard[row + 2, col + 2] == symbol && 
            //        gameBoard.GameBoard[row + 1, col + 1] == symbol)
            //    {
            //        return true;
            //    }

            //    // Diagonal Play (bottom-left to top-right)
            //    if (col + 3 <= cols && row - 3 >= 0 &&
            //        gameBoard.GameBoard[row - 3, col + 3] == symbol &&
            //        gameBoard.GameBoard[row - 2, col + 2] == symbol &&
            //        gameBoard.GameBoard[row - 1, col + 1] == symbol)
            //    {
            //        return true;
            //    }
            //}

            return -1;
        }

        public static int StopsWinningMove(Board gameBoard, string symbol)
        {
            int rows = gameBoard.GameBoard.GetLength(0);
            int cols = gameBoard.GameBoard.GetLength(1);
            string OpSymbol = "O";

            int consecutiveCount = 0;

            // Check vertical
            for (int c = 0; c < cols; c++)
            {
                for (int r = 5; r >= 0; r--)
                {
                    if (gameBoard.GameBoard[r, c] != symbol && gameBoard.GameBoard[r, c] != " ")
                    {
                        consecutiveCount++;
                        if (consecutiveCount == 3)
                        {
                            if (gameBoard.GameBoard[r + 1, c] == symbol || gameBoard.GameBoard[r - 1, c] == symbol)
                            {
                                consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                                break;
                            }

                            return c;
                        }
                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }

            // Check horizontal
            for (int r = 5; r >= 0; r--)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (gameBoard.GameBoard[r, c] != symbol && gameBoard.GameBoard[r, c] != " ")
                    {
                        consecutiveCount++;

                        if (consecutiveCount == 1)
                        {
                            if (c + 3 < cols && (gameBoard.GameBoard[r, c + 2] == OpSymbol && gameBoard.GameBoard[r, c + 3] == OpSymbol))
                            {
                                return c + 1;
                            }
                            else if (c - 3 >= 0 && (gameBoard.GameBoard[r, c - 2] == OpSymbol && gameBoard.GameBoard[r, c - 3] == OpSymbol))
                            {
                                return c - 1;
                            }
                        }

                        if (consecutiveCount == 3)
                        {
                            if (c + 1 < cols && gameBoard.GameBoard[r, c + 1] == " ")
                            {
                                return c + 1;
                            }
                            else if (c - 3 > 0 && gameBoard.GameBoard[r, c - 3] == " ")
                            {
                                return c - 3;
                            }
                        }
                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }

            //for (int c = 0; c < cols; c++)
            //{
            //    for (int r = 5; r >= 0; r--)
            //    {
            //        if (gameBoard.GameBoard[r, c] == oponentSymbol)
            //        {
            //            // Vertical Play
            //            if (r + 3 < rows &&
            //                gameBoard.GameBoard[r + 1, c] == oponentSymbol &&
            //                gameBoard.GameBoard[r + 2, c] == oponentSymbol &&
            //                gameBoard.GameBoard[r + 3, c] == oponentSymbol
            //                )
            //            {
            //                return c;
            //            }

            //            // Horizontal Play
            //            if (c + 3 < cols &&
            //                gameBoard.GameBoard[r, c + 1] == oponentSymbol &&
            //                gameBoard.GameBoard[r, c + 2] == oponentSymbol &&
            //                gameBoard.GameBoard[r, c + 3] == oponentSymbol)
            //            {
            //                return c;
            //            }

            //            // Diagonal Play (top-left to bottom-right)
            //            if (c + 3 < cols && r + 3 < rows &&
            //                gameBoard.GameBoard[r + 1, c + 1] == oponentSymbol &&
            //                gameBoard.GameBoard[r + 2, c + 2] == oponentSymbol &&
            //                gameBoard.GameBoard[r + 3, c + 3] == oponentSymbol)
            //            {
            //                return c;
            //            }

            //            // Diagonal Play (bottom-left to top-right)
            //            if (c + 3 < cols && r - 3 >= 0 &&
            //                gameBoard.GameBoard[r - 1, c + 1] == oponentSymbol &&
            //                gameBoard.GameBoard[r - 2, c + 2] == oponentSymbol &&
            //                gameBoard.GameBoard[r - 3, c + 3] == oponentSymbol)
            //            {
            //                return c;
            //            }
            //        }

            //    }
            //}

            return -1;
        }

        public static int HasPieceNear(Board gameBoard, string symbol)
        {
            int cols = gameBoard.GameBoard.GetLength(0);
            int consecutiveCount = 0;
            int c;

            // Check vertical
            for (c = 0; c <= cols; c++)
            {
                for (int r = 5; r >= 0; r--)
                {
                    if (gameBoard.GameBoard[r, c] != symbol)
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                    else if (gameBoard.GameBoard[r, c] == symbol)
                    {
                        consecutiveCount++;
                        if (consecutiveCount == 2)
                        {
                            if (gameBoard.GameBoard[r - 1, c] != " " || gameBoard.GameBoard[r + 1, c] != symbol)
                            {
                                consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                                break;
                            }

                            return c;
                        }
                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }

            consecutiveCount = 0; // Reset the count for the next check.

            // Check horizontal
            for (int r = 5; r >= 0; r--)
            {
                for (c = 0; c <= cols; c++)
                {
                    if (gameBoard.GameBoard[r, 3] != symbol)
                    {
                        break;
                    }
                    else if (gameBoard.GameBoard[r, c] == symbol)
                    {
                        consecutiveCount++;

                        for (int consCount = 2; consCount > 0; consCount--)
                        {
                            if (consecutiveCount == consCount)
                            {
                                if (c + 1 < cols && gameBoard.GameBoard[r, c + 1] == " ")
                                {
                                    return c + 1;
                                }
                                else if (c - consCount > 0 && gameBoard.GameBoard[r, c - consCount] == " ")
                                {
                                    return c - consCount;
                                }
                            }
                        }

                    }
                    else
                    {
                        consecutiveCount = 0; // Reset the count if symbols are not consecutive.
                    }
                }
            }
            return -1;
        }

    }
}
