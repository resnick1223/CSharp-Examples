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
            int total = 0;
            int max = 7;
            for(int number = 1; number <= max; number++)
            {

                total += number;
                if (number <= 5)
                    Console.Write("{0} + ", number);
                else if(number == 6)
                    Console.Write("... + ", number);
                else if (number >= 7 && number <= max - 1)
                    continue;
                else
                    Console.WriteLine("{0} = {1}", number, total);
            }
        }
    }
}
