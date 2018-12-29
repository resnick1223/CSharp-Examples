using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleStoreLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "iPhone 7",
                    Price = 28900,
                    Categories = new string[] { "iPhone" }
                },
                new Product()
                {
                    Id = 2,
                    Name = "iPhone 7 plus",
                    Price = 31900,
                    Categories = new string[] { "iPhone" }
                }
            };

            Console.WriteLine(products[0].Name);
            Console.WriteLine("共有{0}個產品", products.Length);
        }
    }
}