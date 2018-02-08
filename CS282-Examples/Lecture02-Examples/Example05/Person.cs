using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Person
    {
        public string Name;
        public string Birthday;
        public string Email;
        public Position Pos;
        public double Orientation;

        public void MoveForward(double distance)
        {
            Pos.X = Pos.X + distance * Math.Cos(Orientation * Math.PI / 180.0);
            Pos.Y = Pos.Y + distance * Math.Sin(Orientation * Math.PI / 180.0);
        }

        public void TurnRight(double angle)
        {
            Orientation = Orientation + angle;
        }

        public void ShowPosition()
        {
            Console.WriteLine("{0}的位置:({1}, {2}) 方位:{3}度", Name, Pos.X, Pos.Y, Orientation);
        }

        public void DrawSquare(double width)
        {
            for (var count = 0; count < 4; count++)
            {
                this.MoveForward(width);
                this.TurnRight(90);
                this.ShowPosition();
            }
        }

        public void DrawSquare()
        {
            DrawSquare(100);
        }
    }
}