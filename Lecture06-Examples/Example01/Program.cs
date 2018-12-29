using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();
            int value = int.Parse(Console.ReadLine());

            product1.SetPrice(10);

            product1.SetPrice(value);
            product2.SetPrice(value);

            product1.Price = 99;

            Console.WriteLine(product1.Price);
        }
    }
}