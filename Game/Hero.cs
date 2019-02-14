using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Game
{
    class Hero
    {
        private int _x;
        private int _y;
        private string _name;

        public Hero(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public void MoveRight()
        {
            _x++;
        }

        public void MoveLeft()
        {
            _x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Hero {_name} is at {_x}x{_y}");
        }
    }
}
