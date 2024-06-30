using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Errors
{    
    internal static class InvalidInput
    {
        /// <summary>
        /// Invalid input error message method. Returns an error message and aks for a valid input.
        /// </summary>
        public static void Print()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                    ");
            Console.WriteLine(" Error! Please insert a valid input.");
            Console.WriteLine("                                    ");
            Console.ResetColor();
            Console.ReadLine();
        }

    }
}
