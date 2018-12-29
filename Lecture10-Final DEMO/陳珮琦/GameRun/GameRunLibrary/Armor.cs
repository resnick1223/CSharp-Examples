using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public abstract class Armor : Props, AddDefense
    {
        public abstract void ChangDefense();
    }
}