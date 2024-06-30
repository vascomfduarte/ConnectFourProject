using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.Game.AI;
using ConsoleApp1.GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class TurnProcessor
    {
        public static int Turn(Board gameBoard, Player player)
        {
            string colNum = "";

            if (gameBoard.BoardSize == 1)
            {
                colNum = "(1-7)";
            }
            else if (gameBoard.BoardSize == 2)
            {
                colNum = "(1-16)";
            }

            int playPosition = 0;

            if (player.Name != "AI Opponent")
            {
                int j = 0;
                while (j < 1)
                {
                    ClearConsole.Clear();
                    Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);

                    Console.Write($"{player.Name} ({player.Symbol}), it's your turn. Enter the column number {colNum}: ");

                    if (!int.TryParse(Console.ReadLine(), out playPosition) || playPosition < 1 || playPosition > 7)
                    {
                        InvalidOption.Print();
                        continue;
                    }

                    if (ColumnValidator.CheckFull(playPosition - 1, gameBoard))
                    {
                        FullRow.Print();
                        continue;
                    }

                    // Subtract 1 to convert to zero-based index
                    playPosition -= 1;

                    j++;
                }
            }
            else if (player.Name == "AI Opponent")
            {
                ClearConsole.Clear();
                Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);

                Console.Write($"{player.Name}'s ({player.Symbol}) turn. ");

                //int j = 0;
                //while (j < 1)
                //{
                //    Random rand = new Random();
                //    playPosition = rand.Next(1, 8);

                //    if (ColumnValidator.CheckFull(playPosition, gameBoard))
                //    {
                //        continue;
                //    }

                //    // Subtract 1 to convert to zero-based index
                //    playPosition -= 1;

                //    j++;
                //}

                int j = 0;
                while (j < 1)
                {
                    AI.AI ai = new(gameBoard, player);

                    playPosition = ai.PlayPosition;

                    if (ColumnValidator.CheckFull(playPosition, gameBoard))
                    {
                        continue;
                    }

                    j++;
                }

                Thread.Sleep(1000);
            }

            return playPosition;
        }

    }
}
