using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperEasyMath;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                name = "Elsa",
                theta = 0,
                pos = new Position()
                {
                    x = 10,
                    y = 0
                }
            };
            person.PrintPosition();

            person.MoveForward(100);
            person.PrintPosition();

            person.TurnRight(90);
            person.MoveForward(100);
            person.PrintPosition();

        }
    }
}
