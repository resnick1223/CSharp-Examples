using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(){ Name="iPhone 7", Price=28900},
                new Product(){ Name="iPhone 7+", Price=32900},
                new Product(){ Name="iPhone 6s", Price=25900},
                new Product(){ Name="iPhone 6s+", Price=28900},
                new Product(){ Name="iPad Pro", Price=18900}
            };

            Random random = new Random();
            Product[] shoppingCart = new Product[10];
            for (int index = 0; index < shoppingCart.Length; index++)
            {
                shoppingCart[index] = products[random.Next(0, products.Length)];
            }

            foreach (Product product in shoppingCart)
            {
                Console.WriteLine("{0}: {1}", product.Name, product.Price);
            }
        }
    }
}