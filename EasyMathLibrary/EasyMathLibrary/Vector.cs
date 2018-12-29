using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public enum SortOption
    {
        X = 1, Y, Length
    }

    public class Vector : IComparable
    {
        public static int MaxId { get; set; }
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public static SortOption SortBy;

        public Vector()
            : this(0.0, 0.0)
        {
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.Id = ++MaxId;
        }

        public Vector(Vector v)
            : this(v.X, v.Y)
        {
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public Vector Add(double x, double y)
        {
            this.X += x;
            this.Y += y;
            return this;
        }

        public Vector Add(Vector other)
        {
            return Add(other.X, other.Y);
        }

        public Vector Minus(double x, double y)
        {
            this.X -= x;
            this.Y -= y;
            return this;
        }

        public Vector Minus(Vector other)
        {
            return Minus(other.X, other.Y);
        }

        public Vector Mutiply(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
            return this;
        }

        public override string ToString()
        {
            return string.Format("Vector {3}: (x, y) = ({0}, {1}), Length = {2}"
                , X, Y, Length, Id);
        }

        public static Vector Generate(double min, double max)
        {
            Random random = new Random();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            return new Vector(x, y);
        }

        public static Vector[] Generate(double min, double max, int count)
        {
            Vector[] vectors = new Vector[count];
            EasyRandom random = new EasyRandom();
            for (int index = 0; index < vectors.Length; index++)
            {
                double x = random.NextDouble(min, max);
                double y = random.NextDouble(min, max);
                vectors[index] = new Vector(x, y);
            }

            return vectors;
        }

        public int CompareTo(object obj)
        {
            if (obj is Vector)
            {
                Vector other = obj as Vector;
                switch (Vector.SortBy)
                {
                    case SortOption.X:
                        return Compare(this.X, other.X);

                    case SortOption.Y:
                        return Compare(this.Y, other.Y);

                    case SortOption.Length:
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
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
    }
}