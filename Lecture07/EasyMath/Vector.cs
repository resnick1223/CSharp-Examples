using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        private static Random random;

        public static SortBy SortBy { get; set; }

        private static int count;

        public static int Count
        {
            set
            {
                Vector.count = value >= 0 ? value : 0;
            }

            get
            {
                return Vector.count;
            }
        }

        public double theta;

        /// <summary>
        /// 預設建構式，產生一個零向量
        /// </summary>
        public Vector()
            : this(0, 0)
        {
        }

        /// <summary>
        /// 透過給定x, y分量產生一個向量
        /// </summary>
        /// <param name="x">x分量</param>
        /// <param name="y">y分量</param>
        public Vector(double x, double y)
        {
            Vector.count++;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 透過給定一個value，產生一個X, Y分量相等的向量
        /// </summary>
        /// <param name="value"></param>
        public Vector(double value)
            : this(value, value)
        {
        }

        /// <summary>
        /// 取得向量長度
        /// </summary>
        /// <returns>回傳值為向量長度</returns>

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public double Theta
        {
            get
            {
                if (X == 0.0 && Y == 0.0)
                    return 0.0;
                else if (X == 0.0)
                    return Y > 0 ? 90 : 270;
                else if (Y == 0.0)
                    return X > 0 ? 0 : 180;
                else
                    return Math.Atan(Y / X) * 180.0 / Math.PI;
            }
        }

        public void ScaleX(double factor)
        {
            X *= factor;
        }

        public void ScaleY(double factor)
        {
            Y *= factor;
        }

        public void Scale(double factorX, double factorY)
        {
            ScaleX(factorX);
            ScaleY(factorY);
        }

        public void Scale(double factor)
        {
            ScaleX(factor);
            ScaleY(factor);
        }

        /// <summary>
        /// 列印向量的基本資訊
        /// </summary>
        public void Print()
        {
            Console.WriteLine("(x, y) = ({0}, {1}) Length = {2} Theta = {3}"
                , X, Y, Length, Theta);
        }

        public static Vector Generate(double min, double max)
        {
            //Random random = new Random();
            if (Vector.random == null)
                Vector.random = new Random();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);

            return new Vector(x, y);
        }

        public static Vector[] Generate(int count, double min, double max)
        {
            Vector[] vectors = new Vector[count];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = Vector.Generate(min, max);
            }

            return vectors;
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (Vector vector in vectors)
                vector.Print();
        }

        public int CompareTo(object obj)
        {
            Vector other = obj as Vector;
            switch (SortBy)
            {
                case SortBy.X:
                    return Compare(this.X, other.X);

                case SortBy.Y:
                    return Compare(this.Y, other.Y);

                default:
                    return Compare(this.Length, other.Length);
            }
        }

        private int Compare(double x, double y)
        {
            if (x > y)
                return 1;
            else if (x == y)
                return 0;
            else
                return -1;
        }
    }
}