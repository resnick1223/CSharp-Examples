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
            Vec2[] vectors = Vec2.Generate(-100, 100, 10);
            Vec2.WriteLine(vectors);

            Console.WriteLine("----");
            Vec2.selectedField = SelectedField.Length;
            Vec2.order = Order.ASC;
            Array.Sort(vectors);

            Vec2.WriteLine(vectors);
        }
    }
}