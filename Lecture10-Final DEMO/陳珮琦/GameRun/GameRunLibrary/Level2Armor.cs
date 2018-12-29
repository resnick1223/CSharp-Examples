using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level2Armor : Armor
    {
        public Level2Armor()
        {
            Name = "中階盾牌";
        }

        public override void ChangDefense()
        {
            player.defenseType = DefenseType.SECOND;
        }
    }
}