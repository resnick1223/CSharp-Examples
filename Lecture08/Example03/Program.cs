using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 1;
            int b = a;
            b = 3;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Vector v1 = new Vector(3);
            Console.WriteLine("v1.x = {0}", v1.x);
            Vector v2 = new Vector(3, 4);
            v2.x = 4;
            Console.WriteLine("v1.x = {0}, v2.x = {1}", v1.x, v2.x);
            v1.x = 5;
            Console.WriteLine("v1.x = {0}, v2.x = {1}", v1.x, v2.x);
            Console.WriteLine(Vector.Count);
        }
    }
}