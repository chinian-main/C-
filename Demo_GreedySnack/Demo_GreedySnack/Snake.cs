using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GreedySnack
{
    enum E_MoveDir
    {
        Up,
        Down,
        Left,
        Right
    }
    class Snake : IDraw
    {
        SnackBody[] bodys;
        int nowNum;
        E_MoveDir dir;
        public Snake(int x, int y)
        {
            bodys = new SnackBody[200];
            bodys[0] = new SnackBody(E_SnakeBody_Type.Head, x, y);
            nowNum = 1;
            dir = E_MoveDir.Right;

        }
        public void Draw()
        {
            for (int i = 0; i < nowNum; i++)
            {
                bodys[i].Draw();
            }
        }
        public void Move()
        {
            SnackBody lastBody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastBody.pos.x, lastBody.pos.y);
            Console.Write("  ");

            for(int i=nowNum-1;i>0;i--)
            {
                bodys[i].pos = bodys[i - 1].pos;
            }

            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;

            }
        }
        public void ChangeDir(E_MoveDir dir)
        {
            if (dir == this.dir || nowNum > 1 && (
                this.dir == E_MoveDir.Left && dir == E_MoveDir.Right ||
                this.dir == E_MoveDir.Right && dir == E_MoveDir.Left ||
                this.dir == E_MoveDir.Up && dir == E_MoveDir.Down ||
                this.dir == E_MoveDir.Down && dir == E_MoveDir.Up
                ))return;
            this.dir = dir;
        }
        public bool CheckEnd(Map map)
        {
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos) return true;

            }

            for (int i = 1; i < nowNum; i++)
            {
                if(bodys[0].pos==bodys[i].pos)
                {
                    return true;
                }
            }

            return false;
        }
        public bool CheckSamPos(Position pos)
        {
            for(int i=0;i<nowNum-1;i++)
            {
                if (pos == bodys[i].pos) return true;
            }
            return false;
        }
        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                food.RandomPos(this);
                AddBody();
            }
        }
        private void AddBody()
        {
            bodys[nowNum] = new SnackBody(E_SnakeBody_Type.Body, 0, 0);
            nowNum++;
        }

    }
}
