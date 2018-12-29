using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector start = new Vector()
            {
                X = 1,
                Y = 1
            };
            double w = 2.0;
            double h = 3.0;
            double g = 1.0;
            int numberOfColumn = 2;
            Vector[] vectors = new Vector[7];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = new Vector()
                {
                    X = start.X + (index % numberOfColumn) * (w + g),
                    Y = start.Y + (index / numberOfColumn) * (h + g)
                };
                Console.WriteLine(vectors[index]);
            }
        }
    }
}