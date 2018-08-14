using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperEasyMath
{
    public class Vector : IComparable
    {
        #region 欄位

        private double x;
        private double y;
        private static Random random;
        public static string SortOption;
        public static string OrderOption;

        #endregion 欄位

        #region 屬性

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value > 200)
                {
                    this.x = 200;
                }
                else if (value < -200)
                {
                    this.x = -200;
                }
                else
                {
                    this.x = value;
                }
            }
        }

        public double Y
        {
            get { return this.y; }

            set
            {
                if (value > 200)
                {
                    this.y = 200;
                }
                else if (value < -200)
                {
                    this.y = -200;
                }
                else
                {
                    this.y = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        public int OrderFactor
        {
            get
            {
                return OrderOption == "desc" ? -1 : 1;
            }
        }

        #endregion 屬性

        #region 建構式

        /// <summary>
        /// 建構式，輸入兩個參數 範圍是100~200之間
        /// </summary>
        /// <param name="x">x 分量</param>
        /// <param name="y">y 分量</param>
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 建構式，產生x, y分量相同的向量
        /// </summary>
        /// <param name="value"></param>
        public Vector(double value) : this(value, value)
        {
        }

        /// <summary>
        /// 建構式，產生0向量
        /// </summary>
        public Vector() : this(0)
        {
        }

        #endregion 建構式

        #region 縮放方法

        #region 縮放x方向

        public void ScaleX(double factor)
        {
            this.X *= factor;
        }

        #endregion 縮放x方向

        #region 縮放y方向

        public void ScaleY(double factor)
        {
            this.Y *= factor;
        }

        #endregion 縮放y方向

        #region 給定兩個方向的縮放倍率

        public void Scale(double factorX, double factorY)
        {
            this.ScaleX(factorX);
            this.ScaleY(factorY);
        }

        #endregion 給定兩個方向的縮放倍率

        #endregion 縮放方法

        public override string ToString()
        {
            return string.Format("(x, y) =  ({0}, {1}) Length = {2}"
                , x, y, Length);
        }

        public static Vector Generate()
        {
            if (Vector.random == null)
                Vector.random = new Random();

            double x = random.Next(-200, 201);
            double y = random.Next(-200, 201);
            return new Vector(x, y);
        }

        public static Vector[] Generate(int count)
        {
            Vector[] Vectors = new Vector[count];
            for (int index = 0; index < count; index++)
                Vectors[index] = Vector.Generate();

            return Vectors;
        }

        public static void WriteLine(Vector[] Vectors)
        {
            foreach (Vector Vector in Vectors)
                Console.WriteLine(Vector);
        }

        public int Compare(double a, double b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        public int CompareTo(object obj)
        {
            if (obj is Vector)
            {
                Vector other = obj as Vector;
                switch (SortOption)
                {
                    case "x":
                        return Compare(this.x, other.x) * OrderFactor;

                    case "y":
                        return Compare(this.y, other.y) * OrderFactor;

                    default:
                        return Compare(this.Length, other.Length) * OrderFactor;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}