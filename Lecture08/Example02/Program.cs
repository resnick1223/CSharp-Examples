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
            Vector v = new Vector(3, 4);
            v.Scale(2);
            Console.WriteLine(v);
        }
    }
}