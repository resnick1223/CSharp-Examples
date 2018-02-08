using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            果實能力者 魯夫 = new 果實能力者();
            魯夫.裝上飛行道具(new 鳥鳥果實());
            魯夫.飛行();
            魯夫.卸下飛行道具();
            魯夫.飛行();
            魯夫.裝上飛行道具(new 飛毯());
            魯夫.飛行();
        }
    }
}