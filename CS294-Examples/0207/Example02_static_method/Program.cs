using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathEngine;

namespace Example02_static_method
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vec2[] vectors = Vec2.Generate(20, -100, 100);
            Vec2.WriteLine(vectors);
        }
    }
}