using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int number = 0;
            int max = 1000;
            while (total <= max)
            {
                total += ++number;
            }
            Console.WriteLine("加到{0}，總和是{1},會超過{2}"
                , number, total, max);
        }
    }
}