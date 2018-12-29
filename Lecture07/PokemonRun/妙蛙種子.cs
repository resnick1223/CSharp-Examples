using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public class 妙蛙種子 : 寶可夢
    {


        public 妙蛙種子()
        {
            this.名字 = "妙蛙種子";
            this.編號 = 1;
            this.滿血量 = 20;
            this.血量 = this.滿血量;
        }

        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            另一隻寶可夢.血量 -= 5;
        }
    }
}
