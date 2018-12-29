using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    public class 轉轉果實 : 超人系果實, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我邊轉邊飛，我的飛行能力是很罕見的");
        }
    }
}