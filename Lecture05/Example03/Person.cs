using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class Person
    {
        public string name;

        public Position pos;

        public double theta;

        public void MoveForward(double distance)
        {
            pos.x += distance * Math.Cos(theta * Math.PI / 180.0);
            pos.y += distance * Math.Sin(theta * Math.PI / 180.0);
        }

        public void TurnRight(double deltaTheta)
        {
            theta += deltaTheta;
        }

        public void PrintPosition()
        {
            Console.WriteLine("{0} 現在位置是({1}, {2})", name, pos.x, pos.y);
        }
    }
}
