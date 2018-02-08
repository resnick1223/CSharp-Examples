using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToolBox
{
    public class RandomExtension
    {
        private Random random;

        public RandomExtension()
        {
            this.random = new Random();
        }

        public double NextDouble(double a, double b)
        {
            double y = this.random.NextDouble();
            return (b - a) * y + a;
        }
    }
}