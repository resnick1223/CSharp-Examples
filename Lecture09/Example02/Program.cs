using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            角色 蒙其D路飛 = new 角色();
            蒙其D路飛.飛行();
            蒙其D路飛.裝上飛行裝備(new 鳥鳥果實());
            蒙其D路飛.飛行();
            蒙其D路飛.裝上飛行裝備(new 冒煙果實());
            蒙其D路飛.飛行();
        }
    }
}
