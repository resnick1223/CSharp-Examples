using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
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

        public override void Attack(Pokemon other)
        {
            if (other.Type[0] == PokemonType.FIRE)
                other.CurrentHP -= 3;
            else if (other.Type[0] == PokemonType.BUG)
                other.CurrentHP -= 20;
            else
                base.Attack(other);
        }
    }
}