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
            int[] numbers = RandomGenerator.Generate(200, -100, 100);
            Matrix.Print(numbers);
            Console.WriteLine("max = {0}", Matrix.Max(numbers));
            Console.WriteLine(Matrix.HasOne(3, numbers));
        }
    }
}