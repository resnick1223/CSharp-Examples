using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    // 工廠方法模式 FactoryMethod Pattern
    public class PokemonFactory
    {
        // 工廠方法 FactoryMethod
        public static Pokemon CreateInstance(int nationalNo)
        {
            switch (nationalNo)
            {
                case 2:
                    return new Ivysaur();

                case 4:
                    return new Charmander();

                case 5:
                    return new Charmeleon();

                case 1:
                default:
                    return new Bulbasaur();
            }
        }
    }
}