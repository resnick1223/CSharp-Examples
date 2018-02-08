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
            Vector[] vectors = Vector.Generate(-100, 100, 10);

            Console.WriteLine("排序前:");
            foreach (var v in vectors)
                Console.WriteLine(v);
            Vector.SortBy = SortOption.X;
            Array.Sort(vectors);
            Console.WriteLine("排序後:");
            foreach (var v in vectors)
                Console.WriteLine(v);
        }
    }
}