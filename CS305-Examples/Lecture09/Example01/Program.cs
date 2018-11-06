using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10, -20, 30);
            Vector.WriteLine(vectors);

            Array.Sort(vectors);
            Console.WriteLine("排序後");
            Vector.WriteLine(vectors);
        }
    }
}