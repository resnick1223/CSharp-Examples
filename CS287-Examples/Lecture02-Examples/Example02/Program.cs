using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic a = 5;
            dynamic b = 6;
            Console.WriteLine(a + b);
            a = "5";
            b = 5;
            Console.WriteLine(a + b);
        }
    }
}