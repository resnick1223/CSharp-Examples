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

            int max = 1000;

            int ans = 0;

            while (total <= max)
            {
                total += ++ans;
            }

            Console.WriteLine("加到{0}，總和={1} 超過了{2}", ans, total, max);
        }
    }
}