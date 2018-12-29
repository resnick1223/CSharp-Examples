using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class 妙蛙種子 : 草系寶可夢
    {
        public override void 攻擊(寶可夢 另一隻)
        {
            base.攻擊(另一隻);
            Random random = new Random();
            int 額外傷害 = random.Next(1, 11);
            另一隻.CurrentHp -= 額外傷害;
            Console.WriteLine("產生傷害{0}", 10 + 額外傷害);
        }

        public override int Cp
        {
            get => base.Cp;
            set
            {
                if (value < 50)
                    cp = 50;
                else if (value > 120)
                    cp = 120;
                else
                    cp = value;
            }
        }

        public override string ToString()
        {
            return string.Format("妙蛙種子 \n{0}", base.ToString());
        }
    }
}