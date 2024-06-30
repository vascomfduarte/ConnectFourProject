using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.GameBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class PlayAgain
    {
        public static bool Start(Board gameBoard, string winner) 
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n > ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Want to Play Again? Answer with (Y)es or (N)o: ");
                string answear = (Console.ReadLine()).ToLower();


                if (answear == "y" || answear == "n")
                {
                    if (answear == "y")
                    {
                        return true;
                    }
                    else if (answear == "n")
                    {
                        return false;
                    }
                }
                else if (answear != "y" || answear != "n")
                {
                    InvalidInput.Print();
                    ClearConsole.Clear();
                    Board.Print(gameBoard.GameBoard, gameBoard.BoardSize);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {winner} Won.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                return false;
            }
            
        }            
    }
}
