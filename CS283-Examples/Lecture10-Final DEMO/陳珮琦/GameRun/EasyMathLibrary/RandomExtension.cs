using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public static class RandomExtension
    {
        public static double NextDouble(this Random random, double from, double to)
        {
            return (to - from) * random.NextDouble() + from;
        }
    }
}