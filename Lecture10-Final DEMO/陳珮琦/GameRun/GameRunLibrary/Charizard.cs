using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Charizard : Charmeleon
    {
        public Charizard() : base()
        {
            Name = "噴火龍";
            Number = 6;
            CP = Pokemon.RandomGenerator.Next(540, 1100);
            Weight = Pokemon.RandomGenerator.NextDouble(85.5, 90.5);
            Height = Pokemon.RandomGenerator.NextDouble(1.0, 1.7);
            HP = 78;
            CurrentHP = 78;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            Type.Add(PokemonType.FLYING);
        }
    }
}