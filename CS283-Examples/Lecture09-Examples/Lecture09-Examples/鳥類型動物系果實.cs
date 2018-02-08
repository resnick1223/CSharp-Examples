using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    public abstract class 鳥類型動物系果實 : 動物系果實, IFlyable
    {
        public abstract void Fly();
    }
}