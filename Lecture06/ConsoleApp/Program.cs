using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector.WriteLine(Vector.Generate(20, -1, 1));
        }
    }
}