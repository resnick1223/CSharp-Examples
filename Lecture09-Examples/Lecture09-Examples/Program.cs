using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture09_Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Duck 可達鴨 = new Duck();
            可達鴨
                .裝上可飛行的道具(new 鳥鳥果實())
                .飛行().脫下裝備()
                .裝上可飛行的道具(new 神秘紅寶石())
                .飛行();
        }
    }
}