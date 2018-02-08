using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public abstract class Weapon : Props, AddAttack
    {
        public abstract void ChangAttack();
    }
}