using ConsoleApp1.GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game.AI
{
    public class AI
    {
        // Properties
        public Brain Brain { get; set; }
        public int PlayPosition { get; set; }

        // Contructors
        public AI(Board gameBoard, Player player)
        {
            Brain = new Brain(gameBoard, player);
            PlayPosition = AnalyzePlay(gameBoard, player);
        }

        // Methods
        public static int AnalyzePlay(Board gameBoard, Player player)
        {
            string symbol = player.Symbol;

            // Check if it's the first move
            if (Brain.FirstPlay(gameBoard))
            {
                return 3; // Play position
            }

            // Check for winning move
            int aiPlay = Brain.IsWinningMove(gameBoard, symbol);
            if (aiPlay >= 0)
            {
                return aiPlay;
            }

            // Stop a winning move
            aiPlay = Brain.StopsWinningMove(gameBoard, symbol);
            if (aiPlay >= 0)
            {
                return aiPlay;
            }

            // Check a game piece to play next to
            aiPlay = Brain.HasPieceNear(gameBoard, symbol);
            if (aiPlay >= 0)
            {
                return aiPlay;
            }

            // Blocks opponent move
            //aiPlay = BlocksOpponentMove.Play(gameBoard, symbol);
            //if (aiPlay >= 0)
            //{
            //    return aiPlay;
            //}

            // If no valid position found, generate a random one
            Random rand = new Random();
            int playPosition = rand.Next(1, 7); // Generates a random number between 1 and 6
            return playPosition;
        }
    }
}
