using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animation2D;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person elsa = new Person()
            {
                name = "Elsa",
                position = new Position()
                {
                    x = 0,
                    y = 0
                },
                theta = 0
            };

            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.MoveForward(100);
            elsa.TurnRight(90);
            elsa.MoveForward(100);
            elsa.TurnRight(90);

            Console.WriteLine(elsa.position.x);
        }
    }
}