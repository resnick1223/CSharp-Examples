using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = PokemonFactory.Create(int.Parse(args[0]));
            Pokemon pokemon2 = PokemonFactory.Create(int.Parse(args[1]));
        }
    }
}