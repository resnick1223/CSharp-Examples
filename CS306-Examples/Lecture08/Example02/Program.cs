using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            int 編號1 = int.Parse(args[0]);
            int 編號2 = int.Parse(args[1]);
            寶可夢 寶可夢1 = 寶可夢工廠.產生寶可夢(編號1);
            寶可夢 寶可夢2 = 寶可夢工廠.產生寶可夢(編號2);
            寶可夢1.攻擊(寶可夢2);


        }
    }
}
