using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.org;

namespace Example02
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
                    X = 0.0,
                    Y = 0.0
                },
                Theta = 0.0
            };

            for (int count = 1; count <= 4; ++count)
            {
                elsa.MoveForward(100);
                elsa.TurnRight(90);
            }
            elsa.WriteLine();
        }
    }
}