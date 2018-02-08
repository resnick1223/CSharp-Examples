using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathExtensions;

namespace Example01
{
    public class Vector : IComparable<Vector>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static int Selection { get; set; }

        public Vector(Random random)
        {
            this.X = random.NextDouble(-100.0, 100.0);
            this.Y = random.NextDouble(-100.0, 100.0);
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y);
            }
        }

        public int CompareTo(Vector other)
        {
            switch (Vector.Selection)
            {
                case 1:
                    return this.Compare(this.X, other.X);

                case 2:
                    return this.Compare(this.Y, other.Y);

                case 3:
                    return this.Compare(this.Length, other.Length);

                default:
                    return this.Compare(this.Length, other.Length);
            }
        }

        private int Compare(double a, double b)
        {
            if (a < b)
                return -1;
            else if (a == b)
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return string.Format("Vector = ({0}, {1}), Length = {2}", this.X, this.Y, this.Length);
        }
    }
}