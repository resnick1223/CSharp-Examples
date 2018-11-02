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
            int total = 0;
            int max = 1000;
            int number = 0;
            while (total <= max)
            {
                total += ++number;
            }
            Console.WriteLine("number = {0}, total = {1} 超過 {2}"
                , number, total, max);
        }
    }
}