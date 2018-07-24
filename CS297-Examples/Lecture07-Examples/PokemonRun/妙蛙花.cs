using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public class 妙蛙花 : 妙蛙草
    {
        public 妙蛙花()
        {
            this.名字 = "妙蛙花";
            this.編號 = 3;
            this.滿血量 = 100;
            this.血量 = this.滿血量;
        }

        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            base.攻擊(另一隻寶可夢);
            另一隻寶可夢.血量 -= 10;
        }
    }
}
