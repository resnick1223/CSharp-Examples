using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyGameEngine;

namespace Example02_FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nationalNos = new int[] { 1, 2, 25 };
            Random random = new Random();
            int nationalNo1 = nationalNos[random.Next(0, nationalNos.Length)];
            int nationalNo2 = nationalNos[random.Next(0, nationalNos.Length)];
            Pokemon pokemon1 = PokemonFactory.Create(nationalNo1);
            Pokemon pokemon2 = PokemonFactory.Create(nationalNo2);
        }
    }
}