using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class 美式咖啡 : 飲料元件
    {
        public 美式咖啡()
        {
            價格 = 50;
        }

        public override void 操作()
        {
            Console.WriteLine("美式{0}元", 價格);
        }
    }
}