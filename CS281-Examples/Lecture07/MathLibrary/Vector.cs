using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToolBox;

namespace MathLibrary
{
    public enum OrderBy { ASC, DESC }

    public enum SortBy { X, Y, Distance }

    public class Vector : IComparable
    {
        private static Random random;
        public static SortBy SortBy = SortBy.Distance;
        public static OrderBy OrderBy = OrderBy.ASC;

        #region 屬性

        public double X { get; set; }
        public double Y { get; set; }

        public double Distance
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 屬性

        #region 建構式

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector()
            : this(0.0, 0.0)
        {
        }

        public Vector(Vector v)
            : this(v.X, v.Y)
        {
        }

        #endregion 建構式

        #region Override 基本方法

        public override string ToString()
        {
            return string.Format("Vector = ({0}, {1}), Distance = {2}", this.X, this.Y, this.Distance);
        }

        #endregion Override 基本方法

        #region 靜態方法

        public static Vector Generate()
        {
            if (random == null)
                random = new Random();
            double x = random.NextDouble(-100.0, 100.0);
            double y = random.NextDouble(-100.0, 100.0);
            return new Vector(x, y);
        }

        public static Vector[] Generate(int length)
        {
            Vector[] vectors = new Vector[length];
            for (int index = 0; index < length; index++)
            {
                vectors[index] = Generate();
            }

            return vectors;
        }

        public static void WriteLine(Vector v)
        {
            Console.WriteLine(v);
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (Vector v in vectors)
                WriteLine(v);
        }

        public static void Sort(Vector[] vectors)
        {
            Array.Sort(vectors);
        }

        public static void Sort(Vector[] vectors, SortBy field)
        {
            Vector.SortBy = field;
            Array.Sort(vectors);
        }

        public static void Sort(Vector[] vectors, SortBy field, OrderBy orderBy)
        {
            Vector.SortBy = field;
            Vector.OrderBy = orderBy;
            Array.Sort(vectors);
        }

        #endregion 靜態方法

        public int CompareTo(object obj)
        {
            Vector other = obj as Vector;
            switch (SortBy)
            {
                case SortBy.X:
                    return Compare(this.X, other.X);

                case SortBy.Y:
                    return Compare(this.Y, other.Y);

                case SortBy.Distance:
                    return Compare(this.Distance, other.Distance);

                default:
                    return Compare(this.Distance, other.Distance);
            }
        }

        public int Compare(double a, double b)
        {
            int orderByFactor = Vector.OrderBy == OrderBy.ASC ? 1 : -1;

            if (a > b)
                return 1 * orderByFactor;
            else if (a < b)
                return -1 * orderByFactor;
            else
                return 0;
        }
    }
}