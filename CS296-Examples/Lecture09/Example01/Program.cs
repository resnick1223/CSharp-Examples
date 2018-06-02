using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonCore;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            寶可夢 寶可夢1 = 寶可夢工廠.產生寶可夢(2);
            寶可夢 寶可夢2 = 寶可夢工廠.產生寶可夢(4);
            寶可夢1.攻擊(寶可夢2);
            寶可夢2.攻擊(寶可夢1);
            IComparable<寶可夢> 可以比較的物件 = 寶可夢工廠.產生寶可夢(2);
        }
    }
}
