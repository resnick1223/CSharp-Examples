using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vec3 : Vec2
    {
        protected double z;
        public double Z { get => z; set => z = value; }

        public Vec3(double x, double y, double z)
            : base(x, y)
        {
            this.Z = z;
        }

        public Vec3(double value)
            : this(value, value, value)
        {
        }

        public Vec3() : this(0)
        {
        }

        public Vec3(Vec3 other) : this(other.X, other.Y, other.Z)
        {
        }

        public override Vector Clone()
        {
            return new Vec3(this);
        }

        public override double Length
        {
            get
            {
                return Math.Sqrt(base.Length * base.Length + this.Z * this.Z);
            }
        }

        public override string ToString()
        {
            return string.Format("(x, y, z) = ({0}, {1}, {2}), Length = {3}"
                , this.X, this.Y, this.Z, this.Length.ToString("#.##"));
        }

        public override int CompareTo(object obj)
        {
            Vec3 other = obj as Vec3;
            switch (Vector.Sort)
            {
                case SortBy.Z:
                    return Compare(this.Z, other.Z);

                case SortBy.X:
                case SortBy.Y:
                case SortBy.Length:
                default:
                    return base.CompareTo(obj);
            }
        }

        public new static Vector Generate(double min, double max)
        {
            if (Vec2.random == null)
                Vec2.random = new Random();

            double x = Vec2.random.NextDouble(min, max);
            double y = Vec2.random.NextDouble(min, max);

            return new Vec2(x, y);
        }

        public new static Vector[] Generate(int length, double min, double max)
        {
            Vector[] vectors = new Vec2[length];

            for (int index = 0; index < length; index++)
                vectors[index] = Vec2.Generate(min, max);

            return vectors;
        }
    }
}