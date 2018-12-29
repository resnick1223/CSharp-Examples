using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
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

                case 3:
                    return new Venusaur();

                case 4:
                    return new Charmander();

                case 5:
                    return new Charmeleon();

                case 6:
                    return new Charizard();

                case 7:
                    return new Squirtle();

                case 8:
                    return new Wartortle();

                case 9:
                    return new Blastoise();

                case 10:
                    return new Caterpie();

                case 11:
                    return new Metapod();

                case 12:
                    return new Butterfree();

                case 13:
                    return new Weedle();

                case 14:
                    return new Kakuna();

                case 15:
                    return new Beedrill();

                case 16:
                    return new Pidgey();

                case 17:
                    return new Pidgeotto();

                case 18:
                    return new Pidgeot();

                case 19:
                    return new Rattata();

                case 20:
                    return new Raticate();

                default:
                    return new Bulbasaur();
            }
        }

        public static Pokemon Generate()
        {
            return Create(Pokemon.RandomGenerator.Next(1, 21));
        }

        public static List<Pokemon> Generate(int count)
        {
            List<Pokemon> pokemons = new List<Pokemon>();
            for (int index = 0; index < count; index++)
                pokemons.Add(Create(Pokemon.RandomGenerator.Next(1, 21)));
            return pokemons;
        }
    }
}