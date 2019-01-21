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
            Vec2[] vectors = Vec2.Generate(10, -10, 10);
            Console.WriteLine("===排序前===");
            Vec2.WriteLine(vectors);
            Vec2.Sort = SortBy.Length;
            Console.WriteLine("===排序後===");
            Array.Sort(vectors);
            Vec2.WriteLine(vectors);
        }
    }
}