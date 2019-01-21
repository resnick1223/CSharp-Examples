using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public static class RandomExtension
    {
        /// <summary>
        /// 這是我們自幹的，產生大於或等於min，且小於max的隨機浮點數。
        /// </summary>
        public static double NextDouble(this Random random, double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }
    }
}