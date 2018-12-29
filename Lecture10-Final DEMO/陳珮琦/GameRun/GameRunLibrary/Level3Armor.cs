using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level3Armor : Armor
    {
        public Level3Armor()
        {
            Name = "高階盾牌";
        }

        public override void ChangDefense()
        {
            player.defenseType = DefenseType.FINAL;
        }
    }
}