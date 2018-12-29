using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level2Weapon : Weapon
    {
        public Level2Weapon()
        {
            Name = "中階戰斧";
        }

        public override void ChangAttack()
        {
            player.attackType = AttackType.SECOND;
        }
    }
}