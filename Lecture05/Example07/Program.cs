using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int max = 1000;
            int next = 0;
            while (total <= max)
            {
                total += ++next;
            }
            Console.WriteLine("加到{0}的時候超過{1}，總和 = {2}", next, max, total);
        }
    }
}