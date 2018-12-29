using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 不等於3就列印
            for (int number = 1; number <= 10; number++)
            {
                if (number != 3)
                    Console.WriteLine(number);
            }

            Console.WriteLine("----------------");

            // 等於3 就不印 --> 略過列印的動作
            for (int number = 1; number <= 10; number++)
            {
                if (number == 3)
                    continue;
                Console.WriteLine(number);
            }
        }
    }
}