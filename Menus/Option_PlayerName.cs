using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Option_PlayerName
    {
        public static string[] Assigner(int playerAmount)
        {
            string player1Name = null;
            string player2Name = null;

            while (true)
            {
                ClearConsole.Clear();
                Menu_Game.NewGameMenu();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n >");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Want to define custom names? Answer with (Y)es or (N)o: ");
                string answear = (Console.ReadLine()).ToLower();

                ClearConsole.Clear();
                Menu_Game.NewGameMenu();
                Console.Write("\n   Want to define custom names? Answer with (Y)es or (N)o: ");

                if (answear == "y" || answear == "n")
                {
                    if (answear == "y")
                    {
                        // Selecting names and play order
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("\n\n\n   Enter Player Names");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(":");
                        Console.WriteLine("   ───────────────────────\n");

                        // Player 1 Name
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("   Player 1");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(": ");
                        player1Name = Console.ReadLine();
                        if (player1Name == "")
                            player1Name = "Player 1";

                        // Player 2 Name
                        player2Name = "Player 2";
                        if (playerAmount == 1)
                            player2Name = "AI Opponent";
                        else if (playerAmount == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n Player 2");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": ");
                            player2Name = Console.ReadLine();
                            if (player2Name == "")
                                player2Name = "Player 2";
                        }
                    }
                    else if (answear == "n") 
                    {
                        // Player 1 Name
                        player1Name = "Player 1";

                        // Player 2 Name
                        player2Name = "Player 2";
                        if (playerAmount == 1)
                            player2Name = "AI Opponent";
                    }

                }
                else if (answear != "y" || answear != "n")
                {
                    InvalidInput.Print();
                    continue;
                }

                //Console.WriteLine("\n   ───────────────────────\n");
                Console.WriteLine("\n   \n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Defined Names:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   Player 1: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{player1Name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("| Player 2: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{player2Name}\n\n");
                Console.ForegroundColor = ConsoleColor.White;

                string[] Names = new string[] { player1Name, player2Name };

                return Names;                

            }

        }
    }
}
