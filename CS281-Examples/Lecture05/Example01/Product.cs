using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Product
    {
        public int id;
        public string name;
        private int price;

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int value)
        {
            if (value > 3000)
                this.price = 3000;
            else if (value < 1000)
                this.price = 1000;
            else
                this.price = value;
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 3000)
                    this.price = 3000;
                else if (value < 1000)
                    this.price = 1000;
                else
                {
                    this.price = value;
                }
            }
        }
    }
}