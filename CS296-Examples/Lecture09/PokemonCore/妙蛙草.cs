using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 妙蛙草 : 妙蛙種子
    {
        public 妙蛙草()
        {
            this.名字 = "妙蛙草";
            this.現在血量 = 40;
            this.完整血量 = this.現在血量;
            this.編號 = 2;
            Random random = new Random();
            int number = random.Next(1, 101);
            if(number >= 90)
                this.大絕 = "強力鞭打";
        }

        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            另一隻寶可夢.現在血量 -= 5;
            base.攻擊(另一隻寶可夢);
        }
    }
}
