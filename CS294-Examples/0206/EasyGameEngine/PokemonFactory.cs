using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGameEngine
{
    public class PokemonFactory
    {
        public static Pokemon Create(int nationalNo)
        {
            switch (nationalNo)
            {
                case 1:
                    return new Bulbasaur();

                case 2:
                    return new Ivysaur();

                case 25:
                    return new Pikachu();

                default:
                    return new Bulbasaur();
            }
        }
    }
}