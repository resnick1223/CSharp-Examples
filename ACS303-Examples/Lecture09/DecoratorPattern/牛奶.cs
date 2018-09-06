using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class 牛奶 : 飲料裝飾者
    {
        public 牛奶(飲料元件 想裝飾的飲料) : base(想裝飾的飲料)
        {
            價格 = 想裝飾的飲料.價格 + 15;
        }

        public override void 操作()
        {
            被裝飾的飲料.操作();
            Console.WriteLine("加牛奶 加15元");
        }
    }
}