using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int nationalNo1 = 1;
            int nationalNo2 = 1;

            if (args.Length == 2)
            {
                int.TryParse(args[0], out nationalNo1);
                int.TryParse(args[1], out nationalNo2);
            }
            else if (args.Length == 1)
            {
                int.TryParse(args[0], out nationalNo1);
            }
            else
            {
                Console.WriteLine("未輸入參數，用預設妙蛙種子對戰");
            }

            Pokemon pokemon1 = PokemonFactory.Create(nationalNo1);
            Pokemon pokemon2 = PokemonFactory.Create(nationalNo2);
            pokemon1.Attack(pokemon2);
        }
    }
}