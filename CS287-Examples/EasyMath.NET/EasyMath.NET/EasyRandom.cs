using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath.NET
{
    public class EasyRandom
    {
        private Random random;

        public EasyRandom()
        {
            random = new Random();
        }

        public double NextDouble(double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }

        public double NextDouble(float max)
        {
            return NextDouble(0.0, max);
        }
    }
}