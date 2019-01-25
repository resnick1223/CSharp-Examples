using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class 小火龍 : 寶可夢
    {
        public int 火系屬性值
        {
            get => default(int);
            set
            {
            }
        }

        public override int CompareTo(寶可夢 other)
        {
            throw new NotImplementedException();
        }

        public override void 攻擊(寶可夢 另一隻)
        {
            throw new NotImplementedException();
        }
    }
}