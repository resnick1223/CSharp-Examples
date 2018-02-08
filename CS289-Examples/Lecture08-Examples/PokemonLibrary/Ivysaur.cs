using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur()
        {
            NationalNo = 2;
            Name = "妙蛙草";
            AttackValue = 62;
            Defense = 63;
            Hp = 60;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            other.Hp -= 10;
        }
    }
}