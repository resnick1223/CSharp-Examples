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
            Vector[] vectors = Vector.Generate(5);
            Vector.Sort = VectorSort.X;
            Vector.Order = VectorOrder.ASC;
            Array.Sort(vectors);
            foreach (var v in vectors)
                Console.WriteLine(v);
        }
    }
}