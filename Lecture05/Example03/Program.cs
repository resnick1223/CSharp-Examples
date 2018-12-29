using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example01;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product();
            int price = int.Parse(Console.ReadLine());
            product.Price = price;
            Console.WriteLine(product.Price);
        }
    }
}