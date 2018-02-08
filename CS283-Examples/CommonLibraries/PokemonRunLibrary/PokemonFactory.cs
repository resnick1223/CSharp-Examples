using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunLibrary
{
    public class PokemonFactory
    {
        public static Pokemon Create(int nationalNumber)
        {
            switch (nationalNumber)
            {
                case 1:
                    return new Bulbasaur();

                case 2:
                    return new Ivysaur();

                //case 3:
                //    return new Venusaur();

                case 4:
                    return new Charmander();

                //case 5:
                //    return new Charmeleon();

                //case 6:
                //    return new Charizard();

                //case 7:
                //    return new Squirtle();

                //case 8:
                //    return new Wartortle();

                //case 9:
                //    return new Blastoise();

                default:
                    return new Bulbasaur();
            }
        }

        public static Pokemon Generate()
        {
            return Create(Pokemon.RandomGenerator.Next(1, 10));
        }

        public static List<Pokemon> Generate(int count)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            for (int index = 0; index < count; index++)
                pokemons.Add(Create(Pokemon.RandomGenerator.Next(1, 10)));
            return pokemons;
        }
    }
}