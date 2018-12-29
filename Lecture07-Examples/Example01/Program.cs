using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10);

            Console.WriteLine("排序前:");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }

            Array.Sort(vectors);

            Console.WriteLine("排序後:");
            foreach (Vector v in vectors)
            {
                Console.WriteLine(v);
            }
        }
    }
}