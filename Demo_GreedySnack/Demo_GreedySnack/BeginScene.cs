using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GreedySnack
{
    class BeginScene:BeginOrEndScene
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }
        public override void EnterJDoSomthing()
        {
            if (nowSelIndex == 0)
            {
                 Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
