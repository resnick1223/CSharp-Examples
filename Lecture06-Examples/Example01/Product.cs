using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Product
    {
        private string name;
        private int price;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value > 200)
                    price = 200;
                else if (value < 100)
                    price = 100;
                else
                    price = value;
            }
        }

        public void SetPrice(int value)
        {
            if (value > 200)
                this.price = 200;
            else if (value < 100)
                this.price = 100;
            else
                this.price = value;
        }

        public int GetPrice()
        {
            return this.price;
        }
    }
}