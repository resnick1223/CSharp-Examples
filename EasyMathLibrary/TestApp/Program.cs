using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine(Vector.Generate(-100, 100));
            }

            Console.WriteLine(Vector.TotalVectors);
        }
    }
}