using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolPCLibrary
{
    public class Product
    {
        public static int MaxId;
        private int id;
        public string Name;
        public int SupplierId;
        private int categoryId;
        public string Unit;
        private float price;

        public Product()
        {
            this.id = ++Product.MaxId;
        }

        public float Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value >= 1000)
                    this.price = 1000.0f;
                else if (value < 100f)
                    this.price = 100f;
                else
                    this.price = value;
            }
        }

        public int CategoryId
        {
            get => categoryId;
            set
            {
                this.categoryId = value < 0 ? 0 : value;
            }
        }

        public int Id { get => id; }

        #region 傳統屬性寫法

        public void SetPrice(float value)
        {
            if (value >= 1000)
                this.price = 1000.0f;
            else if (value < 100f)
                this.price = 100f;
            else
                this.price = value;
        }

        public float GetPrice()
        {
            return this.price;
        }

        #endregion 傳統屬性寫法
    }
}