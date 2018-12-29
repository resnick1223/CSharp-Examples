using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class PokemonFactory
    {
        public static Pokemon Create(int nationalNo)
        {
            switch (nationalNo)
            {
                case 2:
                    return new Ivysaur();

                case 3:
                    return new Venusaur();

                case 4:
                    return new Charmander();

                case 1:
                default:
                    return new Bulbasaur();
            }
        }
    }
}