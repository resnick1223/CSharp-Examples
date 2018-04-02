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
            int total = 0;
            int next = 0;
            int max = 1000;
            while (total <= max)
            {
                total += ++next;
            }
            Console.WriteLine("Current Number: {0}, Total: {1}", next, total);
        }
    }
}