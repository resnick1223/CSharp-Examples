using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector v1 = Vector.Generate();
            Console.WriteLine("v1 = " + v1);
            Vector v2 = v1.Clone();
            Console.WriteLine("v2 = " + v2);
            v2.X = -100;
            Console.WriteLine("修改v2後");
            Console.WriteLine("v1 = " + v1);
            Console.WriteLine("v2 = " + v2);
        }
    }
}