using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Venusaur : Ivysaur
    {
        public Venusaur()
        {
            NationalNo = 3;
            Name = "妙蛙花";
            AttackValue = 62;
            Defense = 63;
            Hp = 80;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            other.Hp -= 20;
        }
    }
}