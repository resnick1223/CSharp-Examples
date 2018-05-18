using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            for (int number = 1; number <= 10; number++)
            {
                if (number == 3)
                    continue;
                total += number;
                Console.Write("{0} + ", number);
            }
            Console.WriteLine(" = {0}", total);
        }
    }
}