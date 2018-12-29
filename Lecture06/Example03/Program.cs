using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            for (int number = 1; number <= 100; number++)
            {
                total += number;
                if (number >= 1 && number <= 5)
                {
                    Console.Write("{0} + ", number);
                }
                else if (number == 6)
                {
                    Console.Write("... + ");
                }
                else if (number >= 7 && number <= 99)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0} = {1}", number, total);
                }
            }
        }
    }
}