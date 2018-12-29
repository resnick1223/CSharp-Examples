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
            Pokemon pokemon1 = PokemonFactory.Create("Bulbasaur");
            Pokemon pokemon2 = PokemonFactory.Create("Ivysaur");

            Console.WriteLine(pokemon1);
            Console.WriteLine(pokemon2);
        }
    }
}