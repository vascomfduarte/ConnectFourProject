using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Errors
{
    internal class UnavailableOption
    {
        public static void Print() 
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                  ");
            Console.WriteLine("Error! Please choose one of the available options.");
            Console.WriteLine("                                                  ");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
