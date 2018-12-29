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
            Product product = new Product("筆記本", 1000);

            Console.WriteLine(product.Price);
        }
    }
}