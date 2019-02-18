using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGame.Game;
using ConsoleGame.Gui;

namespace ConsoleGame
{
    class Program
    {
        static void Main()
        {

            Console.CursorVisible = false;

            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();

            Console.ReadKey();

            //GameController myGame = new GameController();
            //myGame.StartGame();
        }
    }
}
