using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.NewFolder
{
    public class Game
    {
        public color Turn = color.Red;
        public Checkers[,] board = new Checkers[8, 8];
        public Game() {
            for (int i = 0; i < 8; i += 2)
            {
                board[i, 0] = new Checkers(color.Black);
                board[i+1, 0] = new Checkers(color.Black);
                board[i, 2] = new Checkers(color.Black);

                board[i, 7] = new Checkers(color.Red);
                board[i+1, 6] = new Checkers(color.Red);
                board[i, 5] = new Checkers(color.Red);
            }
    }
    }
}
