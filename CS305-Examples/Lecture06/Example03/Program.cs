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
            for (int number = 1; number <= 10; number++)
            {
                if (number == 3)
                    continue;

                Console.WriteLine(number);
            }
        }
    }
}