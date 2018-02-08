using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueStatement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            for (int number = 1; number <= 100; number++)
            {
                if (number == 10)
                    continue;
                total += number;
            }
        }
    }
}