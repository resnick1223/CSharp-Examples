using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEasyMath;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            Console.WriteLine(v1.GetX());
            Console.WriteLine(v1.GetLength());
        }
    }
}
