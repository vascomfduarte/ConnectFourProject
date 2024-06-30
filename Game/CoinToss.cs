using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class CoinToss
    {
        public static bool Toss(Player player1, Player player2) 
        {
            string playerPick = null;
            int a = 0;
            while (a < 1)
            {
                ClearConsole.Clear();
                Menu_Game.NewGameMenu();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n   Let's see who plays first. ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n > ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("(H)eads or (T)ails? ");

                Console.ForegroundColor = ConsoleColor.White;
                playerPick = (Console.ReadLine()).ToLower();
                if (playerPick != "h" && playerPick != "t")
                {
                    InvalidInput.Print();
                    continue;
                }
                else
                {
                    ClearConsole.Clear();
                    Menu_Game.NewGameMenu();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n   Let's see who plays first. ");
                    Console.Write("\n\n ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (playerPick == "h")
                        Console.WriteLine("\n   You picked Heads.");
                    else if (playerPick == "t")
                        Console.WriteLine("\n   You picked Tails.");
                }

                a++;
            }


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\n   Flipping Coin");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine(".");
            Thread.Sleep(500);

                        
            Random random = new Random();

            // 0 represents heads, 1 represents tails
            bool isHeads = random.Next(2) == 0;

            Console.SetCursorPosition(3, 14);
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (isHeads)
            {
                Console.Write("\n   It flipped Heads!");
            }
            else
            {
                Console.Write("\n   It flipped Tails!");
            }            

            bool gotItRight = true;

            if (playerPick == "h")
            {
                if (isHeads)
                {
                    Console.WriteLine($" {player1.Name} is the first to play.");
                    gotItRight = true;
                }
                else
                {
                    Console.WriteLine($" {player2.Name} is the first to play.");
                    gotItRight = false;
                }

            }
            else if (playerPick == "t")
            {
                if (isHeads)
                {
                    Console.WriteLine($" {player2.Name} is the first to play.");
                    gotItRight = false;
                }
                else
                {
                    Console.WriteLine($" {player1.Name} is the first to play.");
                    gotItRight = true;
                }
            }           

            PressToContinue.Press();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");

            return gotItRight;
        }
    }
}
