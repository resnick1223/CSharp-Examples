using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product 豆漿 = new Product();
            豆漿.Name = "永和豆漿";
            豆漿.Price = 15;

            Product 油條 = new Product();
            油條.Name = "永和油條";
            油條.Price = 10;

            Customer 元鴻 = new Customer();
            元鴻.Id = 1;
            元鴻.Name = "張元鴻";

            Order 訂單 = new Order();
            訂單.Customer = 元鴻;
            訂單.Id = 1;
            訂單.ProductList.Add(豆漿);
            訂單.ProductList.Add(油條);
        }
    }
}