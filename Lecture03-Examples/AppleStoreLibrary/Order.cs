using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleStoreLibrary
{
    public class Order
    {
        public List<Product> ProductList = new List<Product>();

        public void Add(Product product)
        {
            ProductList.Add(product);
        }

        public int GetTotalPrice()
        {
            int total = 0;
            for (int index = 0; index < ProductList.Count; index++)
            {
                Product product = ProductList[index];

                // 如果賣光 就不做加法
                //if (product.SoldOut)
                //{
                //}
                //else
                //{
                //    total += product.Price;
                //}

                // 如果 沒賣光 就加到總金額
                //if (!product.SoldOut)
                //    total += product.Price;

                // 如果 賣光 就 跳過 加到總金額這件事
                if (product.SoldOut)
                    continue;
                total += product.Price;
            }
            return total;
        }

        public void WriteLine()
        {
            foreach (Product product in ProductList)
            {
                if (product.SoldOut)
                    Console.WriteLine("{0}已售罄，不列入總金額", product.Name);
                else
                    Console.WriteLine("購物車中包含{0}，價格{1}", product.Name, product.Price);
            }

            //for (int index = 0; index < ProductList.Count; index++)
            //{
            //    Product product = ProductList[index];
            //    if (!product.SoldOut)
            //    {
            //        Console.WriteLine("購物車中包含{0}，價格{1}", product.Name, product.Price);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}已售罄，不列入總金額", product.Name);
            //    }
            //}

            Console.WriteLine("總金額:{0}", GetTotalPrice());
        }

        public string ToText()
        {
            string orderString = "";
            foreach (Product product in ProductList)
            {
                orderString += string.Format("產品名稱:{0}, 價格:{1}, 供貨狀態:{2}\n"
                    , product.Name
                    , product.Price
                    , product.SoldOut ? "無法供貨" : "可訂購");
            }
            return orderString;
        }
    }
}