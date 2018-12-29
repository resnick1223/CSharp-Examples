using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = PokemonFactory.Create(args[0]);
            Pokemon pokemon2 = PokemonFactory.Create(args[1]);
            pokemon1.Attack(pokemon2);
            pokemon1.Attack(pokemon2);

            Console.WriteLine(pokemon1.CurrentHp);
            Console.WriteLine(pokemon2.CurrentHp);
        }
    }
}