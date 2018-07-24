using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public abstract class 寶可夢
    {
        public int 編號;
        public string 名字;
        private int 血量欄位;
        public int 血量
        {
            get { return this.血量欄位; }

            set
            {
                this.血量欄位 = value < 0 ? 0 : value;
            }
        }
        public int 滿血量;

        public string 圖片名稱
        {
            get
            {
                if (this.編號 < 10)
                    return "00" + this.編號;
                else if (this.編號 >= 10 && this.編號 < 100)
                    return "0" + this.編號;
                else
                    return this.編號.ToString();
            }
        }

        public abstract void 攻擊(寶可夢 另一隻寶可夢);
    }
}
