using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int xStart = 10;
            int yStart = 10;
            for (int index = 0; index < 10; index++)
            {
                int row = index / 3;
                int col = index % 3;
                int x = xStart + col * 110;
                int y = yStart + row * 110;
                Console.WriteLine("編號{0}, 座標 = ({1}, {2})", index, x, y);
            }
        }
    }
}