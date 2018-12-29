using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonProject;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();

            Console.Write("請輸入閃電鳥的hp:");
            pokemon.Hp = 0;
            bool success = int.TryParse(Console.ReadLine(), out pokemon.Hp);
            if (success)
            {
                Console.WriteLine("閃電鳥的hp:{0}", pokemon.Hp);
            }
            else
            {
                Console.WriteLine("HP輸入不正確，程式結束");
                return;
            }

            Console.Write("請輸入閃電鳥的maxHp:");
            int maxHp = 0;
            success = int.TryParse(Console.ReadLine(), out maxHp);
            Console.WriteLine(success);
        }
    }
}