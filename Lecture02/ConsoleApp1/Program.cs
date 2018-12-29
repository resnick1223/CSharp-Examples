using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonProject;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                Hp = 114,
                MaxHp = 114
            };

            Console.WriteLine("Pokemon Name:{0}, HP: {1}/{2}"
                , pokemon.Name
                , pokemon.Hp
                , pokemon.MaxHp);
        }
    }
}