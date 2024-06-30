using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConsoleApps
{
    internal static class PressToContinue
    {
        /// <summary>
        /// Aks for any input in order to continue outputing.
        /// </summary>
        public static void Press()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n > ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press 'Enter' to continue. ");
            Console.ReadLine();
        }
    }
}
