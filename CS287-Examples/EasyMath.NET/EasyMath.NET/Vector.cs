using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath.NET
{
    public class Vector
    {
        public static int MaxId { get; set; }
        public string Name { get; set; }
        private int id;

        private double x;
        private double y;

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public double X
        {
            get => x;
            set
            {
                if (value > 100000)
                    x = 100000;
                else if (value < -100000)
                    x = -100000;
                else
                    x = value;
            }
        }

        public double Y
        {
            get => y;
            set
            {
                if (value > 100000)
                    y = 100000;
                else if (value < -100000)
                    y = -100000;
                else
                    y = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.id = ++Vector.MaxId;
            this.Name = "Vector-" + this.id;
        }

        public Vector(Vector v)
            : this(v.X, v.Y)
        {
        }

        public Vector()
            : this(0.0, 0.0)
        {
        }

        public Vector Clone()
        {
            return new Vector(this);
        }

        public override string ToString()
        {
            return
                string.Format("{0}, ({1}, {2}), Length = {3}"
                , this.Name
                , this.X
                , this.Y
                , this.Length);
        }

        public static Vector[] Generate(double min, double max, int count)
        {
            Vector[] vectors = new Vector[count];
            Random random = new Random();
            for (int index = 0; index < count; index++)
            {
                double x = random.NextDouble(min, max);
                double y = random.NextDouble(min, max);
                vectors[index] = new Vector(x, y);
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
                Vector.WriteLine(v);
        }
    }
}