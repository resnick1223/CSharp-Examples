using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10, -100, 100);

            Console.WriteLine("排序前");

            Vector.WriteLine(vectors);
            
            Array.Sort(vectors);

            

            Console.WriteLine("排序後");

            Vector.WriteLine(vectors);
        }
    }
}
