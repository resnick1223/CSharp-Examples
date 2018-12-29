using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class 飲料裝飾者 : 飲料元件
    {
        protected 飲料元件 被裝飾的飲料;

        public 飲料裝飾者(飲料元件 想裝飾的飲料)
        {
            被裝飾的飲料 = 想裝飾的飲料;
        }

        public 飲料元件 取消()
        {
            return 被裝飾的飲料;
        }
    }
}