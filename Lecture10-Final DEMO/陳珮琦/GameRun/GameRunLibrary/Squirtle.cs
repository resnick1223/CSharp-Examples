using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Squirtle : Pokemon
    {
        public Squirtle() : base()
        {
            Name = "傑尼龜";
            Number = 7;
            CP = RandomGenerator.Next(300, 450);
            Weight = RandomGenerator.NextDouble(6.8, 9.1);
            Height = RandomGenerator.NextDouble(0.3, 0.5);
            HP = 44;
            CurrentHP = 44;
            PowerStardust = 2200;
            PowerUpCandy = 2;
            EvolveCandy = 25;
            Type.Add(PokemonType.WATER);
        }
    }
}