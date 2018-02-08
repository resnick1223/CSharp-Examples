using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public enum Status
    { A = 10, B, C = 21, D, E }

    public class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.A;

            Console.WriteLine((int)response);
            Console.WriteLine((int)Status.B);
            Console.WriteLine((int)Status.C);
            Console.WriteLine((int)Status.D);
        }
    }
}