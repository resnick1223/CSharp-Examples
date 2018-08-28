using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class Charmander : Pokemon
    {
        public override int Hp
        {
            get => base.Hp;
            set
            {
                if (value < 0)
                    hp = 0;
                else if (value > 300)
                    hp = 300;
                else
                    hp = value;
            }
        }

        public override void Attack(Pokemon other)
        {
            Console.WriteLine("小火龍發動攻擊");
            other.Hp -= 5;
        }
    }
}