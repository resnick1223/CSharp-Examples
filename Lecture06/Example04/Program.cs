using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 物件 pokemon = 一個新的 Pokemon類型的資料
            Pokemon pokemon1 = new Pokemon()
            {
                nationalNo = 1,
                name = "妙蛙種子"
            };

            Pokemon pokemon2 = new Pokemon();
            pokemon2.nationalNo = 2;
            pokemon2.name = "妙蛙草";

            Console.WriteLine(pokemon1.name);
        }
    }
}