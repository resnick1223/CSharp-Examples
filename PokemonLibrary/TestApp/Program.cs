using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = PokemonFactory.Create(1);
            Pokemon pokemon2 = PokemonFactory.Create(2);

            Console.WriteLine(pokemon1);
            Console.WriteLine(pokemon2);
        }
    }
}