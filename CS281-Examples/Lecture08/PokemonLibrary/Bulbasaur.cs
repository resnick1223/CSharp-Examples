using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToolBox;

namespace PokemonLibrary
{
    public class Bulbasaur : GrassTypePokemon
    {
        public Bulbasaur()
        {
            this.Id = 1;
            this.Name = "妙蛙種子";
            this.Height = (float)random.NextDouble(0.5, 1.0);
            this.Weight = (float)random.NextDouble(5, 10);
            this.GrassLevel = 1;
        }
    }
}