using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class 餐點元件
    {
        public int 價格 { get; set; }
        public int 數量 { get; set; }

        public 餐點元件()
        {
            數量 = 1;
        }

        public abstract void 操作();
    }
}