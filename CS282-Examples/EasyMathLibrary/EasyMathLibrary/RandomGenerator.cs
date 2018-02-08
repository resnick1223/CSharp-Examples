using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class RandomGenerator
    {
        private Random random;

        public RandomGenerator()
        {
            random = new Random();
        }

        public double NextDouble(double start, double end)
        {
            return random.NextDouble() * (end - start) + start;
        }

        public double NextDouble()
        {
            return random.NextDouble();
        }

        public int Next(int start, int end)
        {
            return this.random.Next(start, end);
        }
    }
}