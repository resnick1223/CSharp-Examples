using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class Person
    {
        public string Name;
        public Position Pos;
        public double Angle;

        public void MoveForward(double d)
        {
            Pos.X = Pos.X + d * Math.Cos(Angle * Math.PI / 180.0);
            Pos.Y = Pos.Y + d * Math.Sin(Angle * Math.PI / 180.0);
            WriteLine();
        }

        public void TurnRight(double angle)
        {
            Angle = (Angle + angle) % 360.0;
            WriteLine();
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1}, {2}), 方位角:{3}度", Name, Pos.X, Pos.Y, Angle);
        }

        public void DrawSquare(double width)
        {
            for (var count = 0; count < 4; count++)
            {
                MoveForward(100);
                TurnRight(90);
            }
        }
    }
}