using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class 必勝客台大店 : 必勝客
    {
        public override Pizza CreatePizza(string 口味)
        {
            if (口味 == "夏威夷")
                return new 台大夏威夷();
            else if (口味 == "彩菇鮮蔬")
                return new 台大彩菇鮮蔬();
            else
                return new 台大墨西哥();
        }
    }
}