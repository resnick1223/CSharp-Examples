using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 火恐龍 : 小火龍
    {
        public 火恐龍()
        {
            this.名字 = "火恐龍";
            this.現在血量 = 56;
            this.完整血量 = this.現在血量;
            this.編號 = 5;
            this.一般招 = "火花";
            this.大絕 = "噴射火焰";
        }
    }
}
