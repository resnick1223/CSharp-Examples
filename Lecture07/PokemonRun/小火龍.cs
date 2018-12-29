using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public class 小火龍 : 寶可夢
    {
        public 小火龍()
        {
            this.名字 = "小火龍";
            this.編號 = 4;
            this.滿血量 = 18;
            this.血量 = this.滿血量;
        }


        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            Console.WriteLine("小火龍用抓來攻擊");
            另一隻寶可夢.血量 -= 3;
            Console.WriteLine("{0}損失了{1}血量", 另一隻寶可夢.名字, 3);
        }
    }
}
