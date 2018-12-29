using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOrgLibrary
{
    public class Person
    {
        public string Name;
        public Position CurrentPosition;

        public void TurnRight(double angle)
        {
            this.CurrentPosition.Orientation += angle;
        }

        public void MoveForward(double distance)
        {
            double arc = this.CurrentPosition.Orientation * 2.0 * Math.PI / 360.0;
            this.CurrentPosition.X += distance * Math.Cos(arc);
            this.CurrentPosition.Y += distance * Math.Sin(arc);
        }

        public void DrawRectangle(double width)
        {
            Console.WriteLine("開始畫寬度是{0}的方形", width);
            ShowPosition();
            for (int count = 0; count < 4; count++)
            {
                this.MoveForward(width);
                this.TurnRight(90);
                ShowPosition();
            }
        }

        public void ShowPosition()
        {
            Console.WriteLine("{3}的現在位置:({0}, {1}) 方向是:{2}",
                CurrentPosition.X,
                CurrentPosition.Y,
                CurrentPosition.Orientation,
                Name
                );
        }
    }
}