using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = PokemonFactory.CreateInstance(int.Parse(args[0]));
            Pokemon pokemon2 = PokemonFactory.CreateInstance(int.Parse(args[1]));
        }
    }
}