using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class Charmeleon : Charmander
    {
        public override int Hp
        {
            get => base.Hp;
            set
            {
                if (value < 0)
                    hp = 0;
                else if (value > 550)
                    hp = 550;
                else
                    hp = value;
            }
        }
    }
}