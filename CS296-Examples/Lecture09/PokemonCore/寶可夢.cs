using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public abstract class 寶可夢 : IComparable<寶可夢>
    {
        public int 編號;
        public string 名字;
        public int 現在血量;
        public int 完整血量;
        public string 一般招;
        public string 大絕;
        public string 使用招式;

        public int 損失血量
        {
            get
            {
                return this.完整血量 - this.現在血量;
            }
        }

        protected void 初始化招式()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            if (number >= 60)
                this.使用招式 = this.大絕;
            else
                this.使用招式 = this.一般招;
        }

        public virtual void 攻擊(寶可夢 另一隻寶可夢)
        {
            初始化招式();
        }


        public void 列印攻擊訊息(寶可夢 被攻擊的寶可夢)
        {
            Console.WriteLine("{0}使用{1}進行攻擊", this.名字, this.使用招式);
            Console.WriteLine("對{0}造成{1}的損失", 被攻擊的寶可夢.名字, 被攻擊的寶可夢.損失血量);
        }

        public int CompareTo(寶可夢 other)
        {
            if (this.編號 > other.編號)
                return 1;
            else if (this.編號 == other.編號)
                return 0;
            else
                return -1;
        }
    }
}
