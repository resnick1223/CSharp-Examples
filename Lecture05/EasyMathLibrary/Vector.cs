using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Vector : IComparable
    {
        #region 靜態變數

        // 所有向量類別的物件 共用的變數
        private static Random random;

        public static OrderBy CompareMode;
        public static SortingMode SortMode;

        #endregion 靜態變數

        #region 欄位

        private double x;
        private double y;

        #endregion 欄位

        #region 建構式

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector() : this(0, 0)
        {
            // 亂數產生器
            if (Vector.random == null)
                Vector.random = new Random();
            this.X = random.NextDouble(-10, 10);
            this.Y = random.NextDouble(-10, 10);
        }

        public Vector(Vector other) : this(other.x, other.y)
        {
        }

        #endregion 建構式

        #region 屬性

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 10000.0)
                    x = 10000.0;
                else if (value < -10000.0)
                    x = -10000.0;
                else
                    x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 10000.0)
                    y = 10000.0;
                else if (value < -10000.0)
                    y = -10000.0;
                else
                    y = value;
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        public void SetX(Vector other)
        {
            this.X = other.x;
        }

        public void SetY(Vector other)
        {
            this.Y = other.y;
        }

        #endregion 屬性

        #region 方法

        #region 同時設定xy

        public void SetXY(double x, double y)
        {
            X = x;
            Y = y;
        }

        #endregion 同時設定xy

        #region 縮放

        public Vector ScaleX(double factor)
        {
            this.X *= factor;
            return this;
        }

        public Vector ScaleY(double factor)
        {
            this.Y *= factor;
            return this;
        }

        public void Scale(double factor)
        {
            Scale(factor, factor);
        }

        public void Scale(double factorX, double factorY)
        {
            ScaleX(factorX);
            ScaleY(factorY);
        }

        #endregion 縮放

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1}), Length = {2}", X, Y, Length);
        }

        #endregion 方法

        #region 靜態方法

        // TODO 向量產生器
        public static Vector[] Generate(int count, double min, double max)
        {
            // TODO 建立向量陣列
            Vector[] vectors = new Vector[count];

            // TODO Vector.random 被建立了嗎 確定random只被建立一次
            if (Vector.random == null)
                Vector.random = new Random();

            // TODO 建立陣列中每個向量
            for (int index = 0; index < count; index++)
            {
                double x = Vector.random.NextDouble(min, max);
                double y = Vector.random.NextDouble(min, max);
                vectors[index] = new Vector(x, y);
            }

            return vectors;
        }

        public static Vector[] Generate(int count)
        {
            return Vector.Generate(count, -100, 100);
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (var v in vectors)
                Console.WriteLine(v);
        }

        #endregion 靜態方法

        public int CompareTo(object obj)
        {
            if (obj is Vector)
            {
                Vector other = obj as Vector;

                switch (Vector.CompareMode)
                {
                    case OrderBy.X:
                        return Compare(this.X, other.X);

                    case OrderBy.Y:
                        return Compare(this.Y, other.Y);

                    case OrderBy.Length:
                        return Compare(this.Length, other.Length);

                    default:
                        return Compare(this.Length, other.Length);
                }
            }
            else
            {
                return 0;
            }
        }

        public int Compare(double a, double b)
        {
            int result = 1;
            if (a > b)
                result = 1;
            else if (a < b)
                result = -1;
            else
                result = 0;
            return (int)SortMode * result;
        }
    }
}