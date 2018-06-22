using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int next = 0;
            int target = 1000;
            while(total <= target)
            {
                //next++;
                total += next;
            }
            Console.WriteLine("加到{0}時，超過{1}，總和是{2}", next, target, total);
        }
    }
}
