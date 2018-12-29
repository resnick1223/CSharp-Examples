using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace PokemonSorting
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Pokemon[] pokemons = new Pokemon[3];
            pokemons[0] = PokemonFactory.Create("妙蛙種子");
            pokemons[1] = PokemonFactory.Create("妙蛙草");
            pokemons[2] = PokemonFactory.Create("妙蛙草");
            pokemons[0].Cp = 5;
            pokemons[1].Cp = 2;
            pokemons[2].Cp = 10;
            Array.Sort(pokemons);
            foreach (Pokemon p in pokemons)
                Console.WriteLine(p.Cp );

        }
    }
}
