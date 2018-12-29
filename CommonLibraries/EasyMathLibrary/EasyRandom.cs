using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class EasyRandom
    {
        public Random RandomFactory = new Random();

        public int Next(int from, int to)
        {
            return RandomFactory.Next(from, to);
        }

        public double NextDouble(double from, double to)
        {
            return (to - from) * RandomFactory.NextDouble() + from;
        }
    }
}