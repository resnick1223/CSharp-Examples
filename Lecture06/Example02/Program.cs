using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyStoreLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product("iPhone 7", 28900, 0.95f);
            Product product2 = product.Clone();
            Console.WriteLine(product);
            Console.WriteLine(product2);
            Console.WriteLine(Product.TotalProducts);
            product2.Price = 30000;
            Console.WriteLine(product);
            Console.WriteLine(product2);
            product2 = null;
            Product.Print();
        }
    }
}