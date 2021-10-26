using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GreedySnack
{
    class Food:GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("㊖");
        }
        public void RandomPos(Snake snake)
        {
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            pos = new Position(x, y);
            if (snake.CheckSamPos(pos))
                RandomPos(snake);
        }

    }
}
