using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class 鳥鳥果實 : 動物系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("用鳥鳥果實飛行");
        }
    }
}