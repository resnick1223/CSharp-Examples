using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Product
    {
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product() : this("未知品項", 60)
        {
        }

        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int value)
        {
            if (value > 100)
                price = 100;
            else if (value < 50)
                price = 50;
            else
                price = value;
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 100)
                    price = 100;
                else if (value < 50)
                    price = 50;
                else
                    price = value;
            }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}