using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 小火龍 : 寶可夢
    {

        public 小火龍()
        {
            this.名字 = "小火龍";
            this.現在血量 = 54;
            this.完整血量 = this.現在血量;
            this.編號 = 4;
            this.一般招 = "抓";
            this.大絕 = "烈焰濺射";
        }
        public override void 攻擊(寶可夢 另一隻寶可夢)
        {
            base.攻擊(另一隻寶可夢);
            另一隻寶可夢.現在血量 -= 6;
            base.列印攻擊訊息(另一隻寶可夢);
        }
    }
}
