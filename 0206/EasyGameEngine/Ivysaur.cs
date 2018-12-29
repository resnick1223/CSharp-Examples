using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyGameEngine
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            currentHp = 140;
            maxHp = 140;
            name = "妙蛙草";
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            other.CurrentHp -= 10;
        }
    }
}