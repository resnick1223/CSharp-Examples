using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class Level3Weapon : Weapon
    {
        public Level3Weapon()
        {
            Name = "高階戰斧";
        }

        public override void ChangAttack()
        {
            player.attackType = AttackType.FINAL;
        }
    }
}