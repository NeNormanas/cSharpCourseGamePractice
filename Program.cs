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
            int enemyCount = 0;
            Random rnd = new Random();

            // create
            Hero myHero = new Hero(5, 5, "HERO");
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            // print
            myHero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            // move
            myHero.MoveLeft();
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }

            // print
            myHero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Console.ReadKey();
        }
    }
}
