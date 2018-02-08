using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02_WhileLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int next = 0;
            int upperLimit = 1000;
            int total = 0;
            while (total < upperLimit)
            {
                total += ++next;
            }

            Console.WriteLine("next = {0}, total = {1}, upperLimit = {2}"
                , next, total, upperLimit);
        }
    }
}