using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace PokemonApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                Gym gym = new Gym(args);
                gym.fight();
            }
            else

                Console.WriteLine("參數個數錯誤");
        }
    }
}