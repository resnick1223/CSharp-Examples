using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : Pokemon
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
    }
}