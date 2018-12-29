using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class PokemonSingleton
    {
        private static PokemonSingleton instance;

        private PokemonSingleton()
        {
        }

        public static PokemonSingleton GetInstance()
        {
            if (instance == null)
                instance = new PokemonSingleton();

            return instance;
        }
    }
}