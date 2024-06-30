using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleApps
{
    internal class ClearMenu
    {
        /// <summary>
        /// Similar to the ClearConsole method. Designed for the interation in the menus.
        /// </summary>
        public static void Clear()
        {
            int totalConsoleLines = Console.WindowHeight;
            int preservedLines = 15;

            for (int i = 0; i < totalConsoleLines; i++)
            {
                Console.SetCursorPosition(0, preservedLines + i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, preservedLines);
        }
    }
}
