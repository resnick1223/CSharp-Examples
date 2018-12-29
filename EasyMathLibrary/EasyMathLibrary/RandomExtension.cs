using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public static class RandomExtension
    {
        public static double NextDouble(this Random random, double start, double end)
        {
            double x = random.NextDouble();
            return (end - start) * x + start;
        }
    }
}