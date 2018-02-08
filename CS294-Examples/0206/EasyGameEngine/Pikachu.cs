using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGameEngine
{
    public class Pikachu : Pokemon
    {
        public Pikachu() : base()
        {
            currentHp = 120;
            maxHp = 120;
            name = "皮卡丘";
        }
    }
}