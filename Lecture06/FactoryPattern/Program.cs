using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            必勝客 台大分店 = new 必勝客台大店();

            台大分店.訂購("台大夏威夷");
        }
    }
}