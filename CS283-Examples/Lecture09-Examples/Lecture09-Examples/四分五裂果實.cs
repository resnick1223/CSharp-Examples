using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    public class 四分五裂果實 : 超人系果實, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我四分五裂飛來飛去");
        }
    }
}