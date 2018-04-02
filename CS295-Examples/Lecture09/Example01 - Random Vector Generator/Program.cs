using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example01___Random_Vector_Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10, -100, 100);
            Vector.WriteLine(vectors);
        }
    }
}