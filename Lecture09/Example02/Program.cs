using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            角色 魯夫 = new 角色() { 名稱 = "魯夫" };

            魯夫.飛行();

            魯夫.裝上飛行裝備(new 瓦斯果實());

            魯夫.飛行();
        }
    }
}
