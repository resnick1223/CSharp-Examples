using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TODO: 寶可夢的資料變數宣告

            Pokemon pokemon = new Pokemon();
            pokemon.Name = "閃電鳥";

            // TODO: 讓使用者輸入變數的值
            Console.Write("請輸入{0}的HP: ", pokemon.Name);
            pokemon.Hp = int.Parse(Console.ReadLine());

            Console.Write("請輸入{0}的MaxHP: ", pokemon.Name);
            pokemon.MaxHp = int.Parse(Console.ReadLine());

            // TODO: 顯示結果
            Console.WriteLine("Pokemon Name:{0}, HP: {1}/{2}"
                , pokemon.Name
                , pokemon.Hp
                , pokemon.MaxHp);
        }
    }
}