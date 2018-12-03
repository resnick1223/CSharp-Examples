using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon[] pokemons = new Pokemon[10];
            for (int index = 0; index < pokemons.Length; index++)
            {
                pokemons[index] = new Pokemon()
                {
                    name = "妙蛙種子" + (index + 1),
                    hp = 100
                };
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine(pokemon.name);
            }
        }
    }
}