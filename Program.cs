using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Game;

namespace ConsoleGame
{
    class Program
    {
        static void Main()
        {
            GameController myGame = new GameController();
            myGame.StartGame();
        }
    }
}
