using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    public class 角色
    {
        private 具有飛行能力的介面 能飛的裝備;

        public void 裝上飛行裝備(具有飛行能力的介面 撿到的道具)
        {
            this.能飛的裝備 = 撿到的道具;
        }

        public void 飛行()
        {
            if (能飛的裝備 != null)
                this.能飛的裝備.飛行();
            else
                Console.WriteLine("尚未裝上可飛行的裝備");
        }
    }
}