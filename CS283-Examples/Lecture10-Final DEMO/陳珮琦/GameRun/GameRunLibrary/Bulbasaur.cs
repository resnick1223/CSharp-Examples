using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base()
        {
            Name = "妙蛙種子";
            Number = 1;
            HP = 60;
            CurrentHP = 60;
            PowerStardust = 3000;
            PowerUpCandy = 3;
            EvolveCandy = 25;
            Type.Add(PokemonType.GRASS);
            Type.Add(PokemonType.POISSON);
        }
    }
}