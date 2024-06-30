using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class OptionSelector
    {
        public static void SelectorMenu() 
        {
            // Asking for input from the user
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n >");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Enter the option number: ");
        }
    }
}
