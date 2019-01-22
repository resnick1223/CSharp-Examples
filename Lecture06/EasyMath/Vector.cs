using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public abstract class Vector : IComparable
    {
        protected static Random random;
        public static SortBy Sort { get; set; }

        public static void WriteLine(Vector vector)
        {
            Console.WriteLine(vector);
        }

        public static void WriteLine(Vector[] vectors)
        {
            foreach (var vector in vectors)
                Vector.WriteLine(vector);
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

        public abstract int CompareTo(object obj);

        public abstract double Length { get; }
    }
}