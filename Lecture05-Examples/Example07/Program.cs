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
            for (int next = 1; next <= 5; next++)
            {
                if (next == 3)
                    continue;
                total += next;
            }

            Console.WriteLine(total);
        }
    }
}