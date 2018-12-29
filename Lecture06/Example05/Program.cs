using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector v1 = new Vector()
            {
                name = "v1",
                x = 3,
                y = 4
            };

            Vector v2 = v1;

            v1.WriteLine();
            v2.WriteLine();
            Console.WriteLine("修改v2後");
            v2.name = "v2";
            v2.x = 5;
            v2.y = 12;
            v2.Scale(3, 4);
            v1.WriteLine();
            v2.WriteLine();

            // 普通的數字
            int x1 = 3, y1 = 4;
            int x2 = x1, y2 = y1;
            Console.WriteLine("x1 = {0}, y1 = {1}", x1, y1);
            Console.WriteLine("x2 = {0}, y2 = {1}", x2, y2);
            Console.WriteLine("修改x2, y2後");
            x2 = 5;
            y2 = 12;
            Console.WriteLine("x1 = {0}, y1 = {1}", x1, y1);
            Console.WriteLine("x2 = {0}, y2 = {1}", x2, y2);
        }
    }
}