using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.org
{
    public class Person
    {
        public string Name;
        public Position Pos;
        public double Theta;

        public void MoveForward(double d)
        {
            double cosValue =
                (Theta % 360 == 90 || Theta % 360 == 270) ?
                0 : Math.Cos(Theta * Math.PI / 180.0);
            double sinValue =
                (Theta % 360 == 0 || Theta % 360 == 180) ?
                0 : Math.Sin(Theta * Math.PI / 180.0);
            Pos.X += d * cosValue;
            Pos.Y += d * sinValue;
        }

        public void TurnRight(double theta)
        {
            Theta += theta;
            Theta %= 360.0;
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1}, {2}) 方位角:{3}度"
                , Name
                , Pos.X
                , Pos.Y
                , Theta);
        }

        public bool IsHappy()
        {
            return Pos.X >= 200 && Pos.Y >= 30 && Theta >= 10.0;
        }
    }
}