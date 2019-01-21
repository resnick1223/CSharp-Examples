using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vec2 v1 = Vec2.Generate(-10, 10);
            Console.WriteLine("v1: " + v1);
            Vec2 v2 = v1;
            Vec2 v3 = v1.Clone();
            Console.WriteLine("v2: " + v2);
            Console.WriteLine("v3: " + v3);
            Console.WriteLine("===修改v2後===");
            v2.X = 20;
            v2.Y = 20;
            Console.WriteLine("v1: " + v1);
            Console.WriteLine("v2: " + v2);
            Console.WriteLine("v3: " + v3);
        }
    }
}