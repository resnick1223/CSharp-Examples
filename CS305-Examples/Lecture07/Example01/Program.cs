using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                name = "妙蛙種子",
                nationalNo = 1
            };

            Console.WriteLine("寶可夢名稱是{0}", pokemon.name);
        }
    }
}