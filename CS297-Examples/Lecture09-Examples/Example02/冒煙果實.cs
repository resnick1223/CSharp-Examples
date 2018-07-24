using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class 冒煙果實 : 自然系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("用冒煙果實飛行");
        }
    }
}