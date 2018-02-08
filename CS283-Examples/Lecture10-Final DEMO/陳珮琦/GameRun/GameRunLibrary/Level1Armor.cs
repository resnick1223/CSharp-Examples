using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level1Armor : Armor
    {
        public Level1Armor()
        {
            Name = "初階盾牌";
        }

        public override void ChangDefense()
        {
            player.defenseType = DefenseType.FIRST;
        }
    }
}