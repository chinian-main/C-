using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GreedySnack
{
    enum E_SnakeBody_Type
    {
        Head,
        Body
    }
    class SnackBody:GameObject
    {
        private E_SnakeBody_Type type;
        public SnackBody(E_SnakeBody_Type type,int x,int y)
        {
            this.type = type;
            this.pos = new Position(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == E_SnakeBody_Type.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == E_SnakeBody_Type.Head ? "⊙" : "●");

        }
    }
}
