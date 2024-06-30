using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleApps
{
    internal static class ClearConsole
    {
        /// <summary>
        /// Clears the console from any output by overwriting it. 
        /// Done this way in order to remove the flickering effect of overusing console.clear().
        /// </summary>
        public static void Clear()
        {
            int totalConsoleLines = Console.WindowHeight;

            for (int i = 0; i < totalConsoleLines; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, 0);
        }
    }
}
