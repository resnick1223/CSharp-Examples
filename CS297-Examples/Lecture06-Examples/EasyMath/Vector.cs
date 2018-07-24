using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector : IComparable
    {

        #region 所有物件共用的靜態變數
        private static Random random;
        public static string sortableField;

        #endregion

        #region 類別公用的方法 靜態方法
        public static Vector Generate(double min, double max)
        {
            if (Vector.random == null)
                Vector.random = new Random();

            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            return new Vector(x, y);
        }

        public static Vector[] Generate(int count, double min, double max)
        {
            Vector[] vectors = new Vector[count];
            for(int index = 0; index < count; index++)
                vectors[index] = Vector.Generate(min, max);

            return vectors;
        }

        public static void WriteLine(Vector v)
        {
            Console.WriteLine("(x, y) = ({0}, {1}), Length = {2}", v.x, v.y, v.Length.ToString("#.##"));
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (Vector v in vectors)
                Vector.WriteLine(v);
        }

        #endregion

        #region 欄位
        public double x;
        public double y;
        #endregion

        #region 建構式
        /// <summary>
        /// 向量的建構式，使用x分量與y分量建立向量
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// 向量的建構式，預設產生0向量
        /// </summary>
        public Vector() : this(0, 0)
        {
            
        }

        
        #endregion

        #region 縮放的方法

        public Vector ScaleX(double factor)
        {
            this.x *= factor;
            return this;
        }

        public Vector ScaleY(double factor)
        {
            this.y *= factor;
            return this;
        }

        public Vector Scale(double factorX, double factorY)
        {
            return ScaleX(factorX).ScaleY(factorY);

        }
        #endregion

        #region 其他功能
        public void WriteLine()
        {
            Console.WriteLine("(x, y) = ({0}, {1}), Length = {2}", this.x, this.y, this.Length.ToString("#.##"));
        }

        private int Compare(double a, double b)
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

            Vector other = obj as Vector;

            switch (sortableField)
            {
                case "x":
                    return Compare(this.x, other.x);
                case "y":
                    return Compare(this.y, other.y);
                case "length":
                    return Compare(this.Length, other.Length);
                default:
                    return Compare(this.Length, other.Length);

            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }
        #endregion
    }
}
