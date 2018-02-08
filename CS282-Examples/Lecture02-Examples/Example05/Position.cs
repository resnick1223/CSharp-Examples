using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Position
    {
        public double X;
        public double Y;

        private static Random random;

        public static Position Generate()
        {
            if (Position.random == null)
                random = new Random();
            return new Position()
            {
                X = random.Next(-100, 101),
                Y = random.Next(-100, 100)
            };
        }
    }
}