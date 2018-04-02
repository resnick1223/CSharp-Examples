using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class EasyRandom
    {
        private Random random;

        public EasyRandom()
        {
            this.random = new Random();
        }

        public double NextDouble(double min, double max)
        {
            return min + (max - min) * this.random.NextDouble();
        }

        public int Next()
        {
            return this.random.Next();
        }

        public void NextBytes(byte[] buffter)
        {
            this.random.NextBytes(buffter);
        }
    }
}