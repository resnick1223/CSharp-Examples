using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public class 妙蛙草 : 妙蛙種子
    {
        public 妙蛙草()
        {
            this.名字 = "妙蛙草";
            this.編號 = 2;
            this.滿血量 = 40;
            this.血量 = this.滿血量;
        }

        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            base.攻擊(另一隻寶可夢);
            另一隻寶可夢.血量 -= 6;
        }
    }
}
