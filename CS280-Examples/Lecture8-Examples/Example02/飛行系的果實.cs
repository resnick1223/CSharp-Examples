using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class 飛行系的果實 : 惡魔果實, IFlyBehavior
    {
        public virtual void Fly()
        {
            Console.WriteLine("我用飛行系果實飛");
        }
    }
}