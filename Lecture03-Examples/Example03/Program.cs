using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person elsa = new Person()
            {
                Name = "Elsa",
                Pos = new Position()
                {
                    X = 0,
                    Y = 0
                },
                Angle = 0
            };

            for (var count = 0; count < 100000; count++)
            {
                elsa.DrawSquare(100);
                elsa.TurnRight(120);
            }
        }
    }
}