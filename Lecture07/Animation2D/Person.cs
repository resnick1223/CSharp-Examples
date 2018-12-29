using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation2D
{
    public class Person
    {
        public string name;
        public Position position;
        public double theta;

        public void MoveForward(double distance)
        {
            position.x +=
                distance * Math.Cos((theta % 360) * Math.PI / 180.0);
            position.y +=
                distance * Math.Sin((theta % 360) * Math.PI / 180.0);
        }

        public void TurnRight(double angle)
        {
            theta += angle;
        }

        public void TurnLeft(double angle)
        {
            theta -= angle;
        }
    }
}