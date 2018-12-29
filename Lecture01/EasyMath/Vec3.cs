using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Vec3 : Vec2
    {
        private double z;

        protected double Z { get => z; set => z = value; }

        public Vec3(double x, double y, double z)
            : base(x, y)
        {
            this.Z = z;
        }

        public Vec3() : this(0.0, 0.0, 0.0)
        {
        }

        public override double Length
        {
            get { return Math.Sqrt(base.Length * base.Length + this.Z * this.Z); }
        }

        public override string ToString()
        {
            return
                string.Format("(x, y, z) = ({0}, {1}, {2}) Length = {3}"
                , X, Y, Z, Length.ToString("#.##"));
        }
    }
}