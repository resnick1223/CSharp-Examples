using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vec2 : Vector
    {
        protected double x;
        protected double y;

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

        public override double Length
        {
            get
            {
                return Math.Sqrt(this.x * this.x + this.y * this.y);
            }
        }

        public virtual Vector Clone()
        {
            return new Vec2(this);
        }

        public static Vector Generate(double min, double max)
        {
            if (Vec2.random == null)
                Vec2.random = new Random();

            double x = Vec2.random.NextDouble(min, max);
            double y = Vec2.random.NextDouble(min, max);

            return new Vec2(x, y);
        }

        public static Vector[] Generate(int length, double min, double max)
        {
            Vector[] vectors = new Vec2[length];

            for (int index = 0; index < length; index++)
                vectors[index] = Vec2.Generate(min, max);

            return vectors;
        }

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1}), Length = {2}"
                , this.X, this.Y, this.Length.ToString("#.##"));
        }

        public override int CompareTo(object obj)
        {
            // 拋出尚未實作的例外
            // throw new NotImplementedException();
            Vec2 other = null;
            if (obj is Vec2)
            {
                other = obj as Vec2;
                switch (Vector.Sort)
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