using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 10;
            int total = 0;
            int next = 0;
            while(total <= target)
            {
                total += ++next;
            }
            Console.WriteLine("Number = {0}, Total = {1}", next, total);

        }
    }
}
