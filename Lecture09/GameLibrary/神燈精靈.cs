using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary
{
    public class 神燈精靈 : 阿拉丁世界道具, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("用神燈精靈飛行");
        }
    }
}