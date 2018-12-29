using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace EasyMath
{
    public class Vector
    {
        private static Random random;
        private double x;
        private double y;

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value < -1000)
                    this.x = -1000;
                else if (value > 1000)
                    this.x = 1000;
                else
                    this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value < -1000)
                    this.y = -1000;
                else if (value > 1000)
                    this.y = 1000;
                else
                    this.y = value;
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector(double value)
            : this(value, value)
        {
        }

        public Vector()
            : this(0)
        {
        }

        public Vector(Vector other)
            : this(other.X, other.Y)
        {
        }

        public Vector ScaleX(double factor)
        {
            this.X *= factor;
            return this;
        }

        public Vector ScaleY(double factor)
        {
            this.Y *= factor;
            return this;
        }

        public Vector Scale(double factorX, double factorY)
        {
            return ScaleX(factorX).ScaleY(factorY);
        }

        public Vector Scale(double factor)
        {
            return Scale(factor, factor);
        }

        public override string ToString()
        {
            return string.Format("(x, y) = ({0:0.00}, {1:0.00}), Length = {2}", X, Y, Length.ToString("#.##"));
        }

        public static Vector[] Generate(int count, double min, double max)
        {
            Vector[] vectors = new Vector[count];
            if (Vector.random == null)
                Vector.random = new Random();

            for (int index = 0; index < count; index++)
            {
                double x = random.NextDouble(min, max);
                double y = random.NextDouble(min, max);
                vectors[index] = new Vector(x, y);
            }
            return vectors;
        }

        public DataPoint ToDataPoint()
        {
            return new DataPoint(this.x, this.y);
        }

        public static Series ToSeries(Vector[] vectors)
        {
            Series series = new Series();
            foreach (var v in vectors)
                series.Points.Add(v.ToDataPoint());

            return series;
        }

        public static void WriteLine(Vector v)
        {
            Console.WriteLine(v);
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (var v in vectors)
            {
                WriteLine(v);
            }
        }

        public static Series GenerateSeries(int count,
            double min, double max)
        {
            return ToSeries(Vector.Generate(count, min, max));
        }
    }
}