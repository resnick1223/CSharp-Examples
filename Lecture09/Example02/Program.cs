using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEasyMath;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10);

            Vector.WriteLine(vectors);

            Console.WriteLine("-----");

            Vector.SortOption = "";
            Vector.OrderOption = "desc";
            Array.Sort(vectors);

            Vector.WriteLine(vectors);
        }
    }
}