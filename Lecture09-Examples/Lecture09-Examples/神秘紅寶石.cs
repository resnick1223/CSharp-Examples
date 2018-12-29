using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    public class 神秘紅寶石 : 擴充能力道具, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("恭喜您，拾獲可以讓你飛行紅寶石");

            Console.WriteLine("我們用紅寶石來飛吧");
        }
    }
}