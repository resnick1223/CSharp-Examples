using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level1Weapon : Weapon
    {
        public Level1Weapon()
        {
            Name = "初階戰斧";
        }

        public override void ChangAttack()
        {
            player.attackType = AttackType.FIRST;
        }
    }
}