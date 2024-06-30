using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class NewGame
    {
        public static string Start(Board gameBoard, Player player1, Player player2, int windowWidth, int windowHeigth)
        {
            string winner = "tie";

            while (FullBoardValidator.CheckFull(gameBoard) is false)
            {
                if (gameBoard.BoardSize == 2)
                {
                    Console.SetWindowSize(windowWidth, windowHeigth + 15);
                }

                // Player 1 Turn
                int playPosition = TurnProcessor.Turn(gameBoard, player1);

                gameBoard.PlayAssign(gameBoard.GameBoard, playPosition, player1, gameBoard.BoardSize);
                Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);

                if (WinValidator.CheckWin(gameBoard, player1))
                {
                    ClearConsole.Clear();
                    Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {player1.Name} Won.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return player1.Name;
                }

                // Player 2 Turn
                playPosition = TurnProcessor.Turn(gameBoard, player2);                           

                gameBoard.PlayAssign(gameBoard.GameBoard, playPosition, player2, gameBoard.BoardSize);
                Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);
                               
                if (WinValidator.CheckWin(gameBoard, player2))
                {
                    ClearConsole.Clear();
                    Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {player2.Name} Won.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return player2.Name;
                }

            }

            if (FullBoardValidator.CheckFull(gameBoard) is true)
            {
                ClearConsole.Clear();
                Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);
                Console.WriteLine("Game ended with a tie.");
            }

            return winner;
        }
    }
    
}
