using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Game
{
    class Enemy
    {
        private int _id;
        private int _x;
        private int _y;
        private string _name;


        public Enemy(int id, int x, int y, string name)
        {
            this._id = id;
            this._x = x;
            this._y = y;
            this._name = name;
        }

        public void MoveDown()
        {
            _y++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" Enemy {_name} is at {_x}x{_y}");
        }
    }
}
