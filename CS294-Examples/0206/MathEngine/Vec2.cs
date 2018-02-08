using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine
{
    public class Vec2
    {
        #region 欄位

        public double x;
        public double y;

        #endregion 欄位

        #region 屬性

        public double Length
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        #endregion 屬性

        #region 靜態變數

        private static Random random;

        #endregion 靜態變數

        #region 建構式

        public Vec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vec2(double value) : this(value, value)
        {
        }

        public Vec2() : this(0)
        {
        }

        public Vec2(Vec2 other) : this(other.x, other.y)
        {
        }

        #endregion 建構式

        #region 方法

        public void ScaleX(double factor)
        {
            this.x *= factor;
        }

        public void ScaleY(double factor)
        {
            this.y *= factor;
        }

        public void Scale(double factorX, double factorY)
        {
            this.ScaleX(factorX);
            this.ScaleY(factorY);
        }

        public void Scale(double factor)
        {
            this.Scale(factor, factor);
        }

        #endregion 方法

        #region 覆寫方法

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1}), Length = {2}"
                , x, y, Length);
        }

        #endregion 覆寫方法

        #region 靜態方法

        private static double NextDouble(double min, double max)
        {
            if (Vec2.random == null)
                Vec2.random = new Random();
            return (max - min) * random.NextDouble() + min;
        }

        public static Vec2 Generate(double min, double max)
        {
            double x = Vec2.NextDouble(min, max);
            double y = Vec2.NextDouble(min, max);
            return new Vec2(x, y);
        }

        public static Vec2[] Generate(int count, double min, double max)
        {
            Vec2[] vectors = new Vec2[count];
            for (int index = 0; index < count; index++)
            {
                vectors[index] = Vec2.Generate(min, max);
            }
            return vectors;
        }

        public static void WriteLine(Vec2 v)
        {
            Console.WriteLine(v);
        }

        public static void WriteLine(Vec2[] vectors)
        {
            foreach (Vec2 v in vectors)
                Vec2.WriteLine(v);
        }

        #endregion 靜態方法
    }
}