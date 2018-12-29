using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class 寶可夢
    {
        public int 編號;
        public string 名字;
        private int iv;

        public 寶可夢(int 編號, string 名字)
        {
            Random random = new Random();
            this.iv = random.Next(1000);
            this.編號 = 編號;
            this.名字 = 名字;
        }
    }
}