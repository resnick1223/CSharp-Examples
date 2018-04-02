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
            StatusCode status = StatusCode.c;
            Console.WriteLine((int)status);
            Console.WriteLine((StatusCode)30);
        }
    }
}