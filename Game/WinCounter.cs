using ConsoleApp1.ConsoleApps;
using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    internal class WinCounter
    {
        public static void Counter(string winner, Player player1, Player player2, Player tie) 
        {           

            if (winner == "tie")
            {
                tie.WinCount++;
            }
            else if (winner == player1.Name || winner == player2.Name)
            {
                if (winner == player1.Name)
                {
                    player1.WinCount++;
                }
                else if (winner == player2.Name)
                {
                    player2.WinCount++;
                }
            }

            ClearConsole.Clear();
            Menu_Game.NewGameMenu();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n   Games Score: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n   {player1.Name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($": {player1.WinCount}  |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"  {player2.Name}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($": {player2.WinCount}  |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  Ties");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($": {tie.WinCount}\n\n");
            PressToContinue.Press();
        }
    }
}
