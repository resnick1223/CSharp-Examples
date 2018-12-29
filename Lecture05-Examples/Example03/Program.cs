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
            for (int next = 1; next <= 100; next++)
            {
                total += next;
            }
            Console.WriteLine(total);
        }
    }
}