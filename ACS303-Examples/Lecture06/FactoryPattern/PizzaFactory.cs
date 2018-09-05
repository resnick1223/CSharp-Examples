using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string 口味)
        {
            if (口味 == "夏威夷")
                return new 夏威夷();
            else if (口味 == "台大夏威夷")
                return new 台大夏威夷();
            else if (口味 == "師大夏威夷")
                return new 師大夏威夷();
            else if (口味 == "彩菇鮮蔬")
                return new 彩菇鮮蔬();
            else
                return new 墨西哥();
        }
    }
}