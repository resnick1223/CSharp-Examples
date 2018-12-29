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
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector();
            v1.Print();

            v2.Print();
        }
    }
}