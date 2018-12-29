using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunLibrary
{
    public abstract class 寶可夢
    {
        public string 名字 { get; set; }
        public int 編號 { get; set; }
        public int 血量 { get; set; }

        public void 攻擊(寶可夢 另一隻寶可夢)
        {
            Console.WriteLine("{0} 攻擊 {1}", this.名字, 另一隻寶可夢.名字);
        }
    }
}
