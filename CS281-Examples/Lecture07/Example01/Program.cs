using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(5);
            Console.WriteLine("排序前:");
            Vector.WriteLine(vectors);
            Vector.Sort(vectors, SortBy.Y, OrderBy.DESC);
            Console.WriteLine("排序後:");
            Vector.WriteLine(vectors);
        }
    }
}