using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.NewFolder
{
    public class Checkers
    {
        public color Turn { get; set; }
        public bool King = false;


        public Checkers(color black)
        {
            this.Turn = black;
        }
    }
}
