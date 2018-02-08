using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入要加入幾項產品:");
            int count = int.Parse(Console.ReadLine());
            List<Product> productList = new List<Product>();
            for (int index = 1; index <= count; index++)
            {
                Product product = new Product();
                Console.Write("請輸入產品名稱:");
                product.Name = Console.ReadLine();

                Console.Write("請輸入產品價格:");
                product.Price = int.Parse(Console.ReadLine());

                Console.WriteLine("您輸入的產品名稱:{0}，價格{1}", product.Name, product.Price);

                productList.Add(product);
            }
        }
    }
}