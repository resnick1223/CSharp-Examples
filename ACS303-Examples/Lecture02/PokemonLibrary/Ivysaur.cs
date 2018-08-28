using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public override int Hp
        {
            get => base.Hp;
            set
            {
                if (value < 0)
                    hp = 0;
                else if (value > 500)
                    hp = 500;
                else
                    hp = value;
            }
        }
    }
}