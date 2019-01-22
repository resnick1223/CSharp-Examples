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
            Vector vector = new Vec3(1, 2, 3);

            Console.WriteLine(vector);
            Vec2.WriteLine(vector);
        }
    }
}