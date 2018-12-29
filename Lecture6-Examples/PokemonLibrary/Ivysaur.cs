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
            this.Name = "妙蛙草";
            this.NationalNo = 2;
            this.Height = 1.02f;
            this.Weight = 7.36f;
            this.PowerUpCandy[this.Name] = 2;
            this.PowerUpStardust[this.Name] = 2000;
            this.EvolveCandy[this.Name] = 100;
            this.Hp = 185;
        }
    }
}