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
                board[i+1, 1] = new Checkers(color.Black);
                board[i, 2] = new Checkers(color.Black);

                board[i, 7] = new Checkers(color.Red);
                board[i+1, 6] = new Checkers(color.Red);
                board[i, 5] = new Checkers(color.Red);
            }
    }
        public string Serialize()
        {
            string state = Turn.ToString()+"\n";
            for(int y = 0; y < 8; y++)
            {
                for(int x= 0; x<8; x++)
                {
                    if(board[x,y] != null)
                    {
                        Checkers c = board[x, y];
                        state += $"{c.Turn}, {c.King}, {x}, {y} \n";
                    }
                }
            }

            return state;

        }
    }
}
