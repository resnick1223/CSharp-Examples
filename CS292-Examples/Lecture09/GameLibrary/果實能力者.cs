using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLibrary
{
    public class 果實能力者
    {
        private 具有飛行能力的介面 飛行能力道具;

        public void 裝上飛行道具(具有飛行能力的介面 道具)
        {
            this.飛行能力道具 = 道具;
        }

        public void 卸下飛行道具()
        {
            this.飛行能力道具 = null;
        }

        public void 飛行()
        {
            if (飛行能力道具 == null)
                Console.WriteLine("尚未裝上任何具有飛行能力的道具");
            else
                飛行能力道具.飛行();
        }
    }
}