using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Game
{
    public class Player
    {
        // Properties
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int WinCount { get; set; }

        // Contructors
        public Player()
        { }

        public Player(string name, string symbol)
        {
            this.Name = name;
            this.Symbol = symbol;
        }

        // Methods

    }
}
