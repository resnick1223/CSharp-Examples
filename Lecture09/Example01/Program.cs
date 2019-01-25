using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            寶可夢 寶可夢1 = 寶可夢工廠.產生寶可夢實例(1);

            寶可夢1.飛行();

            寶可夢1.裝上裝備(1);
            寶可夢1.飛行();

            寶可夢1.裝上裝備(new 橡膠果實());
            寶可夢1.飛行();

            寶可夢1.裝上裝備(new 四分五裂果實());
            寶可夢1.飛行();

            寶可夢1.裝上裝備(new 飛毯());
            寶可夢1.飛行();
        }
    }
}
