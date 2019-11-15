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
        public void OnPost()
        {
           var form =  Request.Form;
            Game = new Game();
            Game.board
        }
    }
}