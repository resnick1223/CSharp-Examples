using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToolBox
{
    public static class StaticRandomExtension
    {
        public static double NextDouble(this Random random, double a, double b)
        {
            double y = random.NextDouble();
            return (b - a) * y + a;
        }
    }
}