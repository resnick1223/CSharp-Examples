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
            Console.WriteLine((int)Status.ConnectionSuccess);
            Console.WriteLine((int)Status.ConnectionError);
            Console.WriteLine((int)Status.ReadSuccess);
            Console.WriteLine((int)Status.ReadError);

            Console.WriteLine((Status)1);
        }
    }
}