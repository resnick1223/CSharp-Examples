using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : GrassTypePokemon
    {
        public Bulbasaur()
            : base(
                  "妙蛙種子",
                  1,
                  new string[] { "Grass", "Poison" },
                  0.71f,
                  6.9f
                 )
        {
            this.Hp = 200;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            Console.WriteLine("妙蛙光束");
            other.Hp -= 15;
            Console.WriteLine("{0}的HP損失15,剩下{1}", other.Name, other.Hp);
        }
    }
}