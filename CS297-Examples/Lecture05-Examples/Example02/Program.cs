using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example03;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int number = 1; number <= 10; number++)
            {
                total += number;
                if (number <= 5)
                    Console.Write("{0} + ", number);
                else if (number == 6)
                    Console.Write("... + ", number);
                else if (number >= 7 && number <= 9)
                    continue;
                else
                    Console.Write("{0} = ", number);
            }
           
            Console.WriteLine(total);
        }
    }
}
