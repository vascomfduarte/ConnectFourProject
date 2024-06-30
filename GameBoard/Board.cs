using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Game;

namespace ConsoleApp1.GameBoard
{
    public class Board
    {
        // Properties
        public int BoardSize { get; set; }
        public string[,] GameBoard { get; set; }

        // Contructors
        public Board()
        { }

        public Board(int boardSize)
        {
            BoardSize = boardSize;
            GameBoard = Create(boardSize);
        }

        // Methods
        public string[,] Create(int boardSize)
        {
            string[,] gameBoard;

            if (boardSize == 1)
            {
                gameBoard = new string[6, 7];
                FillArray(gameBoard);
                return gameBoard;
            }
            else if (boardSize == 2)
            {
                gameBoard = new string[16, 16];
                FillArray(gameBoard);
                return gameBoard;
            }

            return null;
        }

        public string[,] FillArray(string[,] gameBoard)
        {
            // Assigning a number to each position of the board
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                gameBoard[i, 0] = " ";

                for (int j = 1; j < gameBoard.GetLength(1); j++)
                {
                    gameBoard[i, j] = " ";
                }
            }

            return gameBoard;
        }

        /// <summary>
        /// Prints the chosen game board to the screen.
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="boardSize"></param>
        public static void Print(string[,] gameBoard, int boardSize)
        {
            if (boardSize == 1)
            {
                Console.WriteLine("\n Game Board:\n");
                Console.WriteLine("\t ___________________________________");
                Console.WriteLine("\t| ___  ___  ___  ___  ___  ___  ___ |");

                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    Console.Write("\t||");
                    Console.Write($" ");

                    // Coloring acording to input
                    if (gameBoard[i, 0] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{gameBoard[i, 0]}");
                    }
                    else if (gameBoard[i, 0] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write($"{gameBoard[i, 0]}");
                    }
                    else
                    {
                        if (gameBoard[i, 0] == " ")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"{gameBoard[i, 0]}");
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ||");

                    for (int j = 1; j < gameBoard.GetLength(1); j++)
                    {                        
                        Console.Write(" ");

                        // Coloring acording to input
                        if (gameBoard[i, j] == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{gameBoard[i, j]}");
                        }
                        else if (gameBoard[i, j] == "X")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"{gameBoard[i, j]}");
                        }
                        else
                        {
                            if (gameBoard[i, j] == " ")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"{gameBoard[i, j]}");
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" ||");
                    }

                    Console.WriteLine("\n\t||___||___||___||___||___||___||___||");
                }

                Console.WriteLine("\t|___________________________________|");
                Console.WriteLine("\t                                     ");
                Console.WriteLine("\t   1    2    3    4    5    6    7   \n");

            }
            else if (boardSize == 2)
            {
                Console.WriteLine("\n Game Board:\n");
                Console.WriteLine("\t ________________________________________________________________________________ ");
                Console.WriteLine("\t| ______________________________________________________________________________ |");

                for (int i = 0; i < gameBoard.GetLength(0); i++)
                {
                    Console.Write("\t||");
                    Console.Write($" {gameBoard[i, 0]} ||");

                    //Console.Write("\t||");
                    //Console.Write($" ");

                    //// Coloring acording to input
                    //if (gameBoard[i, 0] == "O")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    Console.Write($"{gameBoard[i, 0]}");
                    //}
                    //else if (gameBoard[i, 0] == "X")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //    Console.Write($"{gameBoard[i, 0]}");
                    //}
                    //else
                    //{
                    //    if (gameBoard[i, 0] == " ")
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.White;
                    //        Console.Write($"{gameBoard[i, 0]}");
                    //    }
                    //}
                    //Console.ForegroundColor = ConsoleColor.White;
                    //Console.Write(" ||");

                    for (int j = 1; j < gameBoard.GetLength(1); j++)
                    {
                        Console.Write($" {gameBoard[i, j]} ||");

                        //Console.Write(" ");

                        //// Coloring acording to input
                        //if (gameBoard[i, j] == "O")
                        //{
                        //    Console.ForegroundColor = ConsoleColor.Red;
                        //    Console.Write($"{gameBoard[i, j]}");
                        //}
                        //else if (gameBoard[i, j] == "X")
                        //{
                        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //    Console.Write($"{gameBoard[i, j]}");
                        //}
                        //else
                        //{
                        //    if (gameBoard[i, j] == " ")
                        //    {
                        //        Console.ForegroundColor = ConsoleColor.White;
                        //        Console.Write($"{gameBoard[i, j]}");
                        //    }
                        //}
                        //Console.ForegroundColor = ConsoleColor.White;
                        //Console.Write(" ||");
                    }

                    Console.WriteLine("\n\t||___||___||___||___||___||___||___||___||___||___||___||___||___||___||___||___||");
                }

                Console.WriteLine("\t|________________________________________________________________________________|");
                Console.WriteLine("\t                                                                                  ");
                Console.WriteLine("\t   1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   \n");
            }
        }

        /// <summary>
        /// Assigns the player's game piece to the chosen board position and shows the piece dropping animation
        /// </summary>
        /// <param name="gameBoard"></param>
        /// <param name="playPosition"></param>
        /// <param name="player"></param>
        /// <param name="boardSize"></param>
        public void PlayAssign(string[,] gameBoard, int playPosition, Player player, int boardSize)
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                if (gameBoard[gameBoard.GetLength(0) - i - 1, playPosition] == " ")
                {
                    for (int j = 0; j < gameBoard.GetLength(0) - i - 1; j++)
                    {
                        Console.SetCursorPosition(0, 0);
                        gameBoard[j, playPosition] = player.Symbol;
                        Print(gameBoard, boardSize);
                        gameBoard[j, playPosition] = " ";

                        if (boardSize == 1)
                            Thread.Sleep(150);
                        else if (boardSize == 2)
                            Thread.Sleep(50);

                        Console.SetCursorPosition(0, 0);
                    }

                    gameBoard[gameBoard.GetLength(0) - i - 1, playPosition] = player.Symbol;
                    break;
                }
            }
        }

    }
}
