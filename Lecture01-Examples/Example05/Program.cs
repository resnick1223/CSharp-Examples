using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            Console.WriteLine(a + b == c);

            Console.WriteLine(1.0 / 2.0 * Math.Sin(Math.PI / 6.0));
        }
    }
}