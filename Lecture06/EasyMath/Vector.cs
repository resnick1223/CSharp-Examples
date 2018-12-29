using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vector : IDisposable, IComparable
    
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        private static Random random;

        public static OrderBy OrderBy { get; set; }
        public static SortOrder SortOrder { get; set; }

        public static int Count { get; set; }

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
            this.X *= factor;
        }

        /// <summary>
        /// 將y分量放大factor倍
        /// </summary>
        /// <param name="factor">縮放倍數</param>
        public void ScaleY(double factor)
        {
            this.Y *= factor;
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

        public double Length
        {
            get
            {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y);
            }
        }
        

        public void WriteLine()
        {
            Console.WriteLine("{2}.x = {0}, {2}.y = {1}"
                , this.X, this.Y, this.Name == null ? "vector" : this.Name);
        }

        public static Vector Generate(double min, double max)
        {
            if (Vector.random == null)
                Vector.random = new Random();

            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);

            return new Vector() { X = x, Y = y };
        }

        public static Vector[] Generate(int count, double min, double max)
        {
            Vector[] vectors = new Vector[count];
            for (int index = 0; index < count; index++)
                vectors[index] = Vector.Generate(min, max);

            return vectors;
        }

        public static void WriteLine(Vector v)
        {
            Console.WriteLine("(x, y) = ({0}, {1}) Length = {2}", v.X, v.Y, v.Length);
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (var v in vectors)
                Vector.WriteLine(v);
        }

        public int CompareTo(object obj)
        {
            Vector other = obj as Vector;
            switch (Vector.OrderBy)
            {
                case OrderBy.X:
                    return Compare(this.X, other.X);
                case OrderBy.Y:
                    return Compare(this.Y, other.Y);
                default:
                    return Compare(this.Length, other.Length);
            }
            
        }

        public int Compare(double a, double b)
        {
            int result = 0;
            if (a > b)
                result = 1;
            else if (a == b)
                result = 0;
            else
                result = -1;

            return result * (int)SortOrder;
        }
    }
}