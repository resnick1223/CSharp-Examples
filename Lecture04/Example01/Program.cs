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
            for(int next = 1; next <= 5; next+=2)
            {
                total += next;
            }
            Console.WriteLine(total);

        }
    }
}
