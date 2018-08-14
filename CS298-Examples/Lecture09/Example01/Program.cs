using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunCore;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon[] pokemons = Pokemon.Generate(1, "妙蛙種子", 10);

            Pokemon.WriteLine(pokemons);

            Array.Sort(pokemons);
            Console.WriteLine("-----");

            Pokemon.WriteLine(pokemons);
        }
    }
}