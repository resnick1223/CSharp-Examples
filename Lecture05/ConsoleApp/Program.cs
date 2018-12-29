using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 3, 5);

            v1.SetX(1);
            v1.SetY(2);
            v1.SetXY(1, 2);
            v1.ScaleX(3).ScaleY(2).ScaleX(3).ScaleY(4);
            v1.z;
        }
    }
}