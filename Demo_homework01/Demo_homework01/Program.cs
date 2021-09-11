using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Demo_homework01
{
   struct PII
    {
        public int x,y;
        public PII(int xx=0,int yy=0)
            {
            x = xx;
            y = yy;
        }
    }
    class Program
    {

        #region 是否能够移动小人方法
        public bool AbleMove(int x,int y)
        {
            if (x - 1 <0 || y - 2 <0 || y + 3 > Console.BufferWidth || x + 2 > Console.BufferHeight)
                return false;
            return true;
        }
        #endregion
        #region 小人
        public void People(int x,int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write("■");
            Console.SetCursorPosition(y, x - 1);
            Console.Write("●");
            Console.SetCursorPosition(y - 2, x-1);
            Console.Write("↖");
            Console.SetCursorPosition(y + 2, x-1);
            Console.Write("↗");
            Console.SetCursorPosition(y - 1, x + 1);
            Console.Write("↙");
            Console.SetCursorPosition(y + 1, x + 1);
            Console.Write("↘");
        }
        #endregion
        #region 小人消失
        public void PeopleDisappear(int x,int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write("  ");
            Console.SetCursorPosition(y, x - 1);
            Console.Write("  ");
            Console.SetCursorPosition(y - 2, x - 1);
            Console.Write("  ");
            Console.SetCursorPosition(y + 2, x - 1);
            Console.Write("  ");
            Console.SetCursorPosition(y - 1, x + 1);
            Console.Write("  ");
            Console.SetCursorPosition(y + 1, x + 1);
            Console.Write("  ");
        }
        #endregion
        #region 攻击模块
        public void Sttack(object pi)
        {
            PII t = (PII)pi;
            int x = t.x;
            int y = t.y;

            if (y + 5 > Console.BufferWidth) return;
            Console.SetCursorPosition(y + 4, x);
            Console.Write("卐");
            y += 4;
            
            while(y<t.y+40&&y+5<Console.BufferWidth)
            {
                Thread.Sleep(500);
                Console.SetCursorPosition(y-1, x);
                Console.Write("    ");
                Console.SetCursorPosition(y + 4, x);
                Console.Write("卐  ");
                y += 4;
            }
            Console.SetCursorPosition(y, x);
            Console.Write("  ");
            return;
        }
        #endregion
        #region 小星星
        public void Init()
        {
            Random ran = new Random();
            for (int i = 0; i < 20; i++)
            {
                int x = ran.Next(5, Console.BufferHeight-5);
                int y = ran.Next(5, Console.BufferWidth-5);
                Console.SetCursorPosition(y, x);
                Console.Write("★");
            }
        }
        #endregion

        static void Main(string[] args)
        {

            Program cla = new Program();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;
            Console.Clear();

            Console.SetWindowSize(100,40);
            Console.SetBufferSize(150,70);
            cla.Init();
            cla.People(20,20);
            int x = 20, y = 20;
           
            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'w':
                    case 'W':
                        if (cla.AbleMove(x - 1, y))
                        {   cla.PeopleDisappear(x, y);
                            cla.People(x - 1, y);
                            x--;
                        }
                      
                        break;
                    case 's':
                    case 'S':
                        if (cla.AbleMove(x + 1, y))
                        {
                            cla.PeopleDisappear(x, y);
                            cla.People(x + 1, y);
                            x++;
                        }
                        break;
                    case 'a':
                    case 'A':
                        if (cla.AbleMove(x , y-2))
                        {
                            cla.PeopleDisappear(x, y);
                            cla.People(x , y-2);
                            y-=2;
                        }
                       
                        break;
                    case 'd':
                    case 'D':
                        if (cla.AbleMove(x , y+2))
                        { 
                            cla.PeopleDisappear(x, y);
                            cla.People(x , y+2);
                            y+=2;
                        }
                        
                        break;
                    case 'j':
                    case 'J':
                        Thread th = new Thread(new ParameterizedThreadStart(cla.Sttack));
                        th.Start(new PII(x,y));
                        break;
                    default: break;
                }
            }
  
        }
    }
}
