using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 一蘭製造;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            一蘭拉麵店 淺草分店 = new 一蘭拉麵店();
            拉麵訂單 帽子哥訂單 = new 拉麵訂單()
            {
                叉燒 = true,
                口味濃淡 = 4,
                油濃郁度 = 3,
                秘製醬汁 = 3,
                蒜泥 = 1.0f,
                蔥 = true,
                麵的軟硬 = 1
            };

            淺草分店.製作拉麵(帽子哥訂單);

            一蘭拉麵店 信義分店 = new 一蘭台灣分店();
            Console.WriteLine(信義分店.煮麵時間);
            信義分店.製作拉麵(帽子哥訂單);
        }
    }
}