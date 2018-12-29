using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class 角色
    {
        public string 名稱 { get; set; }

        private 具有飛行能力的 飛行裝備;

        public void 裝上飛行裝備(具有飛行能力的 裝備)
        {
            飛行裝備 = 裝備;
        }

        public void 脫下飛行裝備()
        {
            飛行裝備 = null;
        }

        public void 飛行()
        {
            Console.Write("{0} ", 名稱);
            if(飛行裝備 == null)
            {
                Console.WriteLine("請先取得並裝上可以飛行的裝備");

            }
            else
            {
                飛行裝備.飛行();
            }
        }
    }
}
