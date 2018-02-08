using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLoopExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int next = 0;
            int total = 0;
            int max = 1000;
            while (total < max)
            {
                total += ++next;
            }

            Console.WriteLine("Number = {0}, Total = {1}"
                , next, total);

            total = 0;
            for (int number = 1; number <= 10; number++)
            {
                if (number == 3)
                    continue;
                total += number;
            }
        }
    }
}