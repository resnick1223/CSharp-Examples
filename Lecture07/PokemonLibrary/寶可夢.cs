using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class 寶可夢 : IComparable<寶可夢>
    {
        public string 名字 { get; set; }

        public int 現在血量 { get; set; }

        public int 滿血量 { get; set; }

        public int 複合戰鬥力 { get; set; }

        public abstract int CompareTo(寶可夢 other);

        public abstract void 攻擊(寶可夢 另一隻);
    }
}