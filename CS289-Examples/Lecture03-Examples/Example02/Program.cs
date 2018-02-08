using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code.Orz;

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
                    X = 10,
                    Y = 20
                },
                Theta = 120
            };

            elsa.TurnRight(90);
            Console.WriteLine(elsa.Theta);
        }
    }
}