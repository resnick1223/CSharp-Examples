using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class GrassTypePokemon : Pokemon
    {
        public int GrassLevel { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" + string.Format("草系等級:{0}", GrassLevel);
        }
    }
}