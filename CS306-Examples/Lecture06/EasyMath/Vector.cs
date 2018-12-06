using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector : IDisposable
    {
        public double x;
        public double y;
        public string name;

        public static int Count;

        public Vector()
        {
            Vector.Count++;
        }

        public void Dispose()
        {
            Vector.Count--;
        }

        #region 縮放方法

        /// <summary>
        /// 將x分量放大factor倍
        /// </summary>
        /// <param name="factor">縮放倍數</param>
        public void ScaleX(double factor)
        {
            this.x *= factor;
        }

        /// <summary>
        /// 將y分量放大factor倍
        /// </summary>
        /// <param name="factor">縮放倍數</param>
        public void ScaleY(double factor)
        {
            this.y *= factor;
        }

        /// <summary>
        /// 同時縮放向量，x分量放大factorX倍，y分量放大factorY倍
        /// </summary>
        /// <param name="factorX">x方向的縮放倍數</param>
        /// <param name="factorY">y方向的縮放倍數</param>
        public void Scale(double factorX, double factorY)
        {
            this.ScaleX(factorX);
            this.ScaleY(factorY);
        }

        #endregion 縮放方法

        public double GetLength()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        public void WriteLine()
        {
            Console.WriteLine("{2}.x = {0}, {2}.y = {1}"
                , this.x, this.y, this.name == null ? "vector" : this.name);
        }
    }
}