using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class Menu_Game
    {
        public static void NewGameMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n   ┌───────────────────┐");

            Console.Write("   │   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("New Game Menu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   │");

            Console.WriteLine("   └───────────────────┘\n");
        }

    }
}
