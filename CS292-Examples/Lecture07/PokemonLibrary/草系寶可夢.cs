using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class 草系寶可夢 : 寶可夢
    {
        public override void 攻擊(寶可夢 另一隻)
        {
            Console.WriteLine("草系寶可夢發動攻擊");
            另一隻.CurrentHp -= 10;
        }

        public override string ToString()
        {
            return string.Format("草系寶可夢 \n{0}", base.ToString());
        }
    }
}