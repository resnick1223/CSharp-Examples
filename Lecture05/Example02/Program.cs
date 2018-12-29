using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int price1 = 28900;
            int price2 = 32900;
            int price3 = price2;
            Console.WriteLine("修改2之前");
            Console.WriteLine("price2 = {0}", price2);
            Console.WriteLine("price3 = {0}", price3);

            price2 = 36000;
            Console.WriteLine("修改2之後");
            Console.WriteLine("price2 = {0}", price2);
            Console.WriteLine("price3 = {0}", price3);
        }
    }
}