using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GreedySnack
{
    class EndScene:BeginOrEndScene
    {
        public EndScene()
        {
            strTitle = "结束游戏";
            strOne = "回到开始界面";
        }
        public override void EnterJDoSomthing()
        {
            if(nowSelIndex==0)
            {
                Game.ChangeScene(E_SceneType.Begin);

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
