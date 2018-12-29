using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = PokemonFactory.CreateInstance(1);
            pokemon.attackBehavior = BehaviorFactory.CreateBehavior("魯夫橡膠戰斧");
            pokemon.Attack(pokemon);
        }
    }
}