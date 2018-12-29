using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public enum VectorSort
    {
        X, Y, Length
    }

    public enum VectorOrder
    {
        ASC = 1, DESC = -1
    }

    public class Vector : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static VectorSort Sort = VectorSort.Length;
        public static VectorOrder Order = VectorOrder.ASC;
        private static Random random;

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(Vector other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        public double Length
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public int CompareTo(object obj)
        {
            if (obj is Vector)
            {
                Vector other = obj as Vector;
                switch (Sort)
                {
                    case VectorSort.Length:
                        return Compare(this.Length, other.Length);

                    case VectorSort.X:
                        return Compare(this.X, other.X);

                    case VectorSort.Y:
                        return Compare(this.Y, other.Y);

                    default:
                        return Compare(this.Length, other.Length);
                }
            }
            else
            {
                return 0;
            }
        }

        private int Compare(double a, double b)
        {
            int result = 0;
            if (a > b)
                result = 1;
            else if (a == b)
                result = 0;
            else
                result = -1;

            return result * (int)Order;
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public static Vector Generate()
        {
            if (random == null)
                random = new Random();
            Vector vector = new Vector()
            {
                X = random.NextDouble(-100, 100),
                Y = random.NextDouble(-100, 100)
            };
            return vector;
        }

        public static Vector[] Generate(int count)
        {
            Vector[] vectors = new Vector[count];
            for (int index = 0; index < count; index++)
                vectors[index] = Vector.Generate();
            return vectors;
        }

        public override string ToString()
        {
            return string.Format("Vector:({0}, {1}), Length:{2}", X, Y, Length);
        }
    }
}