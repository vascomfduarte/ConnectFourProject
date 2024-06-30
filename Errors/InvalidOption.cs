﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Errors
{
    internal class InvalidOption
    {
        /// <summary>
        /// Invalid option error message method. Returns an error message and aks for a valid option.
        /// </summary>
        public static void Print()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                   ");
            Console.WriteLine(" Error! Please choose one of the available options.");
            Console.WriteLine("                                                   ");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}