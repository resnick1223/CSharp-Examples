using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vec2 : IComparable<Vec2>, IComparable
    {
        protected static Random random;
        public static Order order { get; set; }
        public static SelectedField selectedField { get; set; }
        protected double x;
        protected double y;

        public double X { get => x; set => x = value; }

        public double Y { get => this.y; set => this.y = value; }

        public Vec2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vec2() : this(0.0, 0.0)
        {
        }

        public virtual double Length
        {
            get { return Math.Sqrt(this.X * this.X + this.Y * this.Y); }
        }

        public int OrderFactor
        {
            get { return order == Order.ASC ? 1 : -1; }
        }

        public int CompareTo(object obj)
        {
            if (obj is Vec2)
            {
                Vec2 other = obj as Vec2;
                switch (selectedField)
                {
                    case SelectedField.X:
                        return Compare(this.x, other.x);

                    case SelectedField.Y:
                        return Compare(this.y, other.y);

                    case SelectedField.Length:
                    default:
                        return Compare(this.Length, other.Length);
                }
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1}) Length = {2}", X, Y, Length.ToString("#.##"));
        }

        public static Vec2 Generate(double min, double max)
        {
            if (Vec2.random == null)
                Vec2.random = new Random();
            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            return new Vec2(x, y);
        }

        public static Vec2[] Generate(double min, double max, int count)
        {
            Vec2[] vectors = new Vec2[count];
            for (int index = 0; index < vectors.Length; index++)
            {
                vectors[index] = Vec2.Generate(min, max);
            }

            return vectors;
        }

        // 靜態方法
        public static void WriteLine(Vec2 v)
        {
            Console.WriteLine(v);
        }

        public static void WriteLine(Vec2[] vectors)
        {
            foreach (var vector in vectors)
                Vec2.WriteLine(vector);
        }

        public int CompareTo(Vec2 other)
        {
            switch (selectedField)
            {
                case SelectedField.X:
                    return Compare(this.x, other.x);

                case SelectedField.Y:
                    return Compare(this.y, other.y);

                case SelectedField.Length:
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
            return result * OrderFactor;
        }

        public static string ToString(Vec2[] vectors)
        {
            string result = "";
            foreach (var vector in vectors)
                result += vector.ToString() + "\n";
            return result;
        }
    }
}