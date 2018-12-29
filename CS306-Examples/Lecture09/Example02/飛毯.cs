using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class 飛毯 : 加強型道具, 具有飛行能力的
    {
        public void 飛行()
        {
            Console.WriteLine("使用飛毯飛");
        }
    }
}