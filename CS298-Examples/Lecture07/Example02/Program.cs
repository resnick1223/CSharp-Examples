using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunCore;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon.WriteLine(Pokemon.Generate(1, "妙蛙種子", 10));
        }
    }
}