using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStoreLibrary
{
    public class Product : IDisposable
    {
        private string name;
        private int price;
        private float discount;
        public static int TotalProducts = 0;

        #region 建構式

        public Product(string name, int price, float discount)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            TotalProducts++;
        }

        public Product(string name, int price)
            : this(name, price, 1.0f)
        {
        }

        public Product(Product product)
            : this(product.Name, product.Price, product.Discount)
        {
        }

        public Product()
            : this("No Name", 0, 1.0f)
        {
        }

        #endregion 建構式

        #region 屬性

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set
            {
                if (value < 0)
                    price = 0;
                else if (value > 50000)
                    price = 50000;
                else
                    price = value;
            }
        }

        public float Discount
        {
            get => this.discount;
            set
            {
                if (value < 0.0f)
                    this.discount = 0.0f;
                else if (value > 1.0f)
                    this.discount = 1.0f;
                else
                    this.discount = value;
            }
        }

        public string DiscountMessage
        {
            get
            {
                return this.Discount == 1.0f ? "不打折" : this.Discount * 10 + "折";
            }
        }

        #endregion 屬性

        public Product Clone()
        {
            return new Product(this);
        }

        // 把這個物件 轉成 字串
        public override string ToString()
        {
            return string.Format("品名:{0}\n價格:{1}\n折扣:{2}", this.Name, this.Price, this.DiscountMessage);
        }

        public static void Print()
        {
            Console.WriteLine(TotalProducts);
        }

        public void Dispose()
        {
            TotalProducts--;
        }
    }
}