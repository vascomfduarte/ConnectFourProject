using ConsoleApp1.ConsoleApps;
using ConsoleApp1.GameBoard;
using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class GameAssembler
    {
        public static void Game(int playerAmount, int boardSize, int windowWidth, int windowHeigth)
        {        
            ClearConsole.Clear();
            Menu_Game.NewGameMenu();

            string[] Names = Option_PlayerName.Assigner(playerAmount);

            Player player1 = new Player(Names[0], "O");
            Player player2 = new Player(Names[1], "X");
            Player tie = new Player("tie", "");

            PressToContinue.Press();
            Menu_Game.NewGameMenu();

            string winner = null;
            bool playAgain = false;
            do
            {
                Board board = new Board(boardSize);                

                if (playAgain)
                {
                    WinCounter.Counter(winner, player1, player2, tie);
                }

                if (CoinToss.Toss(player1, player2))
                {
                    winner = NewGame.Start(board, player1, player2, windowWidth, windowHeigth);                    
                }
                else
                {
                    winner = NewGame.Start(board, player2, player1, windowWidth, windowHeigth);                    
                }

                playAgain = PlayAgain.Start(board,winner);                

            } while (playAgain);

        }

    }
}
