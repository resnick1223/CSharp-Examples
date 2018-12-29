using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleStoreLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order myOrder = new Order();

            myOrder.Add(new Product()
            {
                Id = 1,
                Name = "iPad Pro 10.5",
                Price = 23900,
                SoldOut = false
            });

            myOrder.Add(new Product()
            {
                Id = 1,
                Name = "iPad Pro 10.5",
                Price = 23900,
                SoldOut = false
            });

            myOrder.Add(new Product()
            {
                Id = 2,
                Name = "iPhone 7 plus",
                Price = 28900,
                SoldOut = true
            });

            myOrder.WriteLine();
        }
    }
}