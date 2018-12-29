using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = Vector.Generate(10, 20);
            Console.WriteLine(v.Length);
            Vector.WriteLine(v);
        }
    }
}
