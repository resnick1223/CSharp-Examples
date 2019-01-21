using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vec2 : IComparable
    {
        protected double x;
        protected double y;
        protected static Random random;
        public static SortBy Sort { get; set; }

        public Vec2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vec2(double value) : this(value, value)
        {
        }

        public Vec2() : this(0.0)
        {
        }

        public Vec2(Vec2 other) : this(other.X, other.Y)
        {
        }

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        public Vec2 Clone()
        {
            return new Vec2(this);
        }

        public static Vec2 Generate(double min, double max)
        {
            if (Vec2.random == null)
                Vec2.random = new Random();

            double x = Vec2.random.NextDouble(min, max);
            double y = Vec2.random.NextDouble(min, max);

            return new Vec2(x, y);
        }

        public static Vec2[] Generate(int length, double min, double max)
        {
            Vec2[] vectors = new Vec2[length];

            for (int index = 0; index < length; index++)
                vectors[index] = Vec2.Generate(min, max);

            return vectors;
        }

        public static void WriteLine(Vec2 vector)
        {
            Console.WriteLine(vector);
        }

        public static void WriteLine(Vec2[] vectors)
        {
            foreach (var vector in vectors)
                Vec2.WriteLine(vector);
        }

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1}), Length = {2}"
                , this.X, this.Y, this.Length.ToString("#.##"));
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

        public int CompareTo(object obj)
        {
            // 拋出尚未實作的例外
            // throw new NotImplementedException();
            Vec2 other = null;
            if (obj is Vec2)
            {
                other = obj as Vec2;
                switch (Vec2.Sort)
                {
                    case SortBy.X:
                        return Compare(this.X, other.X);

                    case SortBy.Y:
                        return Compare(this.Y, other.Y);

                    case SortBy.Length:
                    default:
                        return Compare(this.Length, other.Length);
                }
            }
            else
            {
                return 0;
            }
        }
    }
}