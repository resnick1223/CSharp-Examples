using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example01;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                id = 1,
                name = "iPhone 8",
                Price = 28900
            };

            Product product2 = new Product()
            {
                id = 2,
                name = "iPhone 8+",
                Price = 30900
            };

            Product product3 = product2;
            Console.WriteLine("修改product2之前");
            Console.WriteLine("product 2\n name:{0}, price:{1}", product2.name, product2.Price);
            Console.WriteLine("product 3\n name:{0}, price:{1}", product3.name, product3.Price);

            Console.WriteLine("修改product2之後");
            product2.Price = 35000;
            Console.WriteLine("product 2\n name:{0}, price:{1}", product2.name, product2.Price);
            Console.WriteLine("product 3\n name:{0}, price:{1}", product3.name, product3.Price);
        }
    }
}