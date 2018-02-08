using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolPCLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product a = new Product();
            a.Price = 40.0f;
            Product b = new Product();
            b.Price = 45.0f;
            Product c = b;

            Console.WriteLine("a.Id = {0}, a.Price = {1}", a.Id, a.Price);
            Console.WriteLine("b.Id = {0}, b.Price = {1}", b.Id, b.Price);
            Console.WriteLine("c.Id = {0}, c.Price = {1}", c.Id, c.Price);
        }
    }
}