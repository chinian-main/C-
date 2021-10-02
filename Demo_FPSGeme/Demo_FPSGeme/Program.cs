using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Demo_FPSGeme
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Weapon w1 = new Weapon();
            p1.NowWeapon();
            Random ran = new Random();
            //随机捡到十次武器
            for(int i=0;i<10;i++)
            {
                Console.WriteLine();
                Thread.Sleep(1000);
                int t = ran.Next(1, 5);
                switch (t)
                {
                    case 1:w1 = new Dagger();p1.PickWeapon(w1); break;
                    case 2:w1 = new HandGun(); p1.PickWeapon(w1); break;
                    case 3:w1 = new ShotGun(); p1.PickWeapon(w1); break;
                    case 4:w1 = new SubMachineGun(); p1.PickWeapon(w1); break; 

                }
            }
            Console.ReadKey();
        }
    }
}
