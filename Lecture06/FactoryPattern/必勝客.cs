using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public abstract class 必勝客
    {
        public Pizza 訂購(string 口味)
        {
            Pizza pizza = PizzaFactory.CreatePizza(口味);
            pizza.準備材料();
            pizza.烘焙();
            pizza.切片();
            pizza.裝箱();

            return pizza;
        }

        public abstract Pizza CreatePizza(string 口味);
    }
}