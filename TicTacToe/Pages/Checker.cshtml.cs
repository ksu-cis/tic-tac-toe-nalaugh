using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicTacToe.NewFolder;

namespace TicTacToe.Pages
{
    public class CheckerModel : PageModel
    {
        public Game Game;

        public void OnGet()
        {
            Game = new Game();
        }
        public void OnPost(int checkersX, int checkery, int spX, int sqY)
        {
           var form =  Request.Form;
            Game = new Game();
            Checkers checkers = Game.board[checkersX, checkery];
            Game.board[spX, sqY] = checkers;
            Game.board[checkersX, checkery] = null;
        }
    }
}