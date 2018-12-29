using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    // 靜態類別
    public static class RandomExtension
    {
        // 擴充方法
        // this 後面接要擴充的物件 --> 外掛
        public static double NextDouble(this Random random, double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }
    }
}