using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(-100, 100, 10);
            Vector.WriteLine(vectors);
        }
    }
}