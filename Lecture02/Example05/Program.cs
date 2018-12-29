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
            float a = 0.2f;
            float b = 0.7f;
            float c = 0.9f;
            Console.WriteLine("a + b = c? {0}", a + b > c);
        }
    }
}