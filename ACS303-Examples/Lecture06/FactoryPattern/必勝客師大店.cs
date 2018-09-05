using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class 必勝客師大店 : 必勝客
    {
        public override Pizza CreatePizza(string 口味)
        {
            if (口味 == "夏威夷")
                return new 師大夏威夷();
            else if (口味 == "彩菇鮮蔬")
                return new 師大彩菇鮮蔬();
            else
                return new 師大墨西哥();
        }
    }
}