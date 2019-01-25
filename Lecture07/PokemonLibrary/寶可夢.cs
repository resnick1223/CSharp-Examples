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

        protected 具有飛行能力的 裝備;

        public void 飛行()
        {
            if (裝備 == null)
            {
                Console.WriteLine("此角色尚未裝備具有飛行能力的道具");
            }
            else
            {
                裝備.飛行();
            }
        }

        public void 裝上裝備(object 裝備物件)
        {
            if (裝備物件 is 具有飛行能力的)
            {
                裝備 = 裝備物件 as 具有飛行能力的;
            }
            else
            {
                裝備 = null;
            }
        }
    }
}