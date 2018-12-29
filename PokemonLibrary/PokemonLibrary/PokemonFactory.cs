using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class PokemonFactory
    {
        public static Pokemon Create(string name)
        {
            switch (name)
            {
                case "Bulbasaur":
                    return new Bulbasaur();

                case "Ivysaur":
                    return new Ivysaur();

                default:
                    return new Bulbasaur();
            }
        }
    }
}