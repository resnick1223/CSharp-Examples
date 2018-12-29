using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeOrgLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person elsa = new Person();
            elsa.Name = "Elsa";
            elsa.CurrentPosition = new Position()
            {
                X = 0.0,
                Y = 100.0,
                Orientation = 0.0
            };

            elsa.MoveForward(200);
            elsa.ShowPosition();
            elsa.DrawRectangle(20);
        }
    }
}