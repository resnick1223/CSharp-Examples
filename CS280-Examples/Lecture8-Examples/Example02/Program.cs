using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Duck 紅頭鴨 = new Duck();
            紅頭鴨.Equip(new 老鷹果實());
            紅頭鴨.Fly();
            紅頭鴨.Equip(null);
            紅頭鴨.Fly();
        }
    }
}