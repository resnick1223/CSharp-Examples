using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public class Vector : IDisposable
    {
        private static Random random;
        public static int TotalVectors;

        #region 欄位與屬性

        public double X { get; set; }
        public double Y { get; set; }

        public double Length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        #endregion 欄位與屬性

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
            Vector.TotalVectors++;
        }

        public Vector()
        {
            Vector.TotalVectors++;
        }

        public static Vector Generate(double min, double max)
        {
            if (Vector.random == null)
                Vector.random = new Random();

            double x = random.NextDouble(min, max);
            double y = random.NextDouble(min, max);
            Vector v = new Vector(x, y);
            return v;
        }

        public Vector ScaleX(double factor)
        {
            X *= factor;

            return this;
        }

        public Vector ScaleY(double factor)
        {
            Y *= factor;

            return this;
        }

        public Vector Scale(double factorX, double factorY)
        {
            return this.ScaleX(factorX).ScaleY(factorY);
        }

        public override string ToString()
        {
            return string.Format("(x, y) = ({0}, {1})", X, Y);
        }

        public void Dispose()
        {
            TotalVectors--;
        }
    }
}