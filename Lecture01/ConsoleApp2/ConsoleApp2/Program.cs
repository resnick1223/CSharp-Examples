using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 區域變數
            int pokemonCp = 1860;
            string pokemonName = "閃電鳥";
            int pokemonHp = 114;
            int pokemonMaxHp = 114;

            // 短浮點數 7位
            float pokemonWeight = 30.87f;

            // 長浮點數 15位
            double pokemonHeight = 1.18;

            int playerStardust = 277396;
            int playerZapdosCandy = 3;

            int pokemonPowerUpStardust = 2500;
            int pokemonPowerUpCandy = 2;

            bool pokemonCanPowerUp =
                playerStardust >= pokemonPowerUpStardust &&
                playerZapdosCandy >= pokemonPowerUpCandy;

            string pokemonInfomation = "寶可夢名稱:{0}\nHP:{1}/{2}";
            Console.WriteLine(pokemonInfomation
                , pokemonName, pokemonHp, pokemonMaxHp);
            Console.WriteLine("{0}能進化嗎? {1}", pokemonName, pokemonCanPowerUp);
        }
    }
}