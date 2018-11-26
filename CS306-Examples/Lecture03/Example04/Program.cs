using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                name = "妙蛙種子",
                hp = 20
            };
            Console.WriteLine(pokemon.hp + 3);
            Console.WriteLine(pokemon.hp);
            pokemon.hp += 3;
            Console.WriteLine(pokemon.hp);
        }
    }
}