using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunCore;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon();
            Pokemon pokemon2 = new Pokemon();
            pokemon1.DisplayInfo();
            pokemon2.Attack(pokemon1);
            pokemon1.DisplayInfo();
        }
    }
}