using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal static class Logo
    {
        public static void GameLogo()
        {
            Console.Clear();

            Console.WriteLine("\n");

            // First Line
            // GamePiece
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t███╗   ");


            // Second Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t █████╗                              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("███████╗                          ");
            // GamePiece
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" █╔█║");


            // Third Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t██╔══██╗██╗    ██╗ ██████╗ ███╗   ██╗");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██╔════╝ ██████╗ ██╗   ██╗█████╗");
            // GamePiece
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\t███║");


            // Fourth Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t███████║██║    ██║██╔════╝ ██╔██╗ ██║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█████╗  ██╔═══██║██║   ██║██╔══██╗");
            // GamePiece
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ███╗");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("███╗");


            // Fifth Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t██╔══██║██║    ██║██║   ██║██║╚██╗██║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██╔══╝  ██║   ██║██║   ██║██████╔╝");
            // GamePiece    
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" █╔█║");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("█╔█║");


            // Sixth Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t██║  ██║██████╗██║╚██████╔╝██║  ╚███║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██║     ╚██████╔╝╚██████╔╝██╔══██╗");
            // GamePiece
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ███║");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("███║");


            // Seventh Line
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t╚═╝  ╚═╝╚═════╝╚═╝ ╚═════╝ ╚═╝   ╚══╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("╚═╝      ╚═════╝  ╚═════╝ ╚═╝  ╚═╝");
            // GamePiece
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" ╚══╝");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("╚══╝");
                
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n                                     [Console Edition v1.3]");
            Console.WriteLine("\n                                   Developed by Vasco Duarte");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
