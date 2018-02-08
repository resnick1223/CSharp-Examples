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
                case "妙蛙種子":
                    return new Bulbasaur();

                case "妙蛙草":
                    return new Ivysaur();

                default:
                    return new Bulbasaur();
            }
        }
    }
}