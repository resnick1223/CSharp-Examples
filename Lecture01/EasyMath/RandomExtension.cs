using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    // 靜態類別
    public static class RandomExtension
    {
        /// <summary>
        /// 隨機產生一個浮點數，範圍在min與max之間。
        /// </summary>
        /// <param name="random"></param>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        // 擴充功能
        public static double NextDouble(this Random random, double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }
    }
}