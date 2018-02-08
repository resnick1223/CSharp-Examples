using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
    public class Charmander : Pokemon
    {
        public Charmander()
        {
            Name = "小火龍";
            Number = 4;
            HP = 54;
            CurrentHP = 54;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 25;
            Type.Add(PokemonType.FIRE);
            Type.Add(PokemonType.POISSON);
        }
    }
}