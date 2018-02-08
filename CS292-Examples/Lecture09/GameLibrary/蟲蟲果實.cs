using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary
{
    public class 蟲蟲果實 : 動物系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("用蟲蟲果實飛行");
        }
    }
}