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
            for (int a = 0; a < 10; a++)
            {
                Console.Write("a = {0} : ", a);
                for (int b = 0; b < a; b++)
                {
                    Console.Write("{0}, ", b);
                }
                Console.WriteLine();
            }
        }
    }
}