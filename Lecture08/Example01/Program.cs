using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = null;
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    pokemon = PokemonFactory.Create(int.Parse(arg));
                    Console.WriteLine(pokemon);
                }
            }
            else
            {
                Console.WriteLine("未輸入編號，產生預設值:妙蛙種子");
                pokemon = PokemonFactory.Create(1);
                Console.WriteLine(pokemon);
            }
        }
    }
}