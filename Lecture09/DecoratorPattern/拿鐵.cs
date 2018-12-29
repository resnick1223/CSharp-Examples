using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class 拿鐵 : 飲料元件
    {
        public 拿鐵()
        {
            價格 = 60;
        }

        public override void 操作()
        {
            Console.WriteLine("拿鐵{0}元", 價格);
        }
    }
}