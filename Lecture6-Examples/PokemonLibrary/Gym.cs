using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Gym
    {
        public Pokemon[] pokemons;
        private Random random;

        public Gym(string[] names)
        {
            pokemons = new Pokemon[names.Length];
            this.random = new Random();
            for (int index = 0; index < pokemons.Length; index++)
            {
                pokemons[index] = PokemonFactory.Create(names[index]);
            }
        }

        public void fight()
        {
            int a = this.RandomGenerator(0, this.pokemons.Length);
            int b = this.RandomGenerator(0, this.pokemons.Length);
            pokemons[a].Attack(pokemons[b]);
        }

        private int RandomGenerator(int from, int to)
        {
            double result = (to - from) * this.random.NextDouble() + from;
            return (int)result;
        }
    }
}