using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FPSGeme
{
    class Player
    {
        public Weapon MyWeapon;
        public Player() 
        {
            MyWeapon = new Dagger();
            
        }
        public void PickWeapon(Weapon t)//捡武器
        {
            MyWeapon = t;
            Console.WriteLine("更换武器成功！！！");
            this.NowWeapon();

        }
        public void NowWeapon()//当前武器是什么
        {
            Console.Write("现在,");
            if(MyWeapon is Dagger)
            {
                Console.WriteLine("我手上有一把匕首");
            }
            else
            {
                if(MyWeapon is HandGun)
                {
                    Console.WriteLine("我手上有一把手枪");
                }
                else
                {
                    if(MyWeapon is ShotGun)
                    {
                        Console.WriteLine("我手上有一把散弹枪");
                    }
                    else
                    {
                        if(MyWeapon is SubMachineGun)
                        {
                            Console.WriteLine("我手上有一把冲锋枪");
                        }
                    }
                }
            }

        }
    }
}
