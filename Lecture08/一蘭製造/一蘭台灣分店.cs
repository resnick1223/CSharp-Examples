using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 一蘭製造
{
    public class 一蘭台灣分店 : 一蘭拉麵店
    {
        protected override void 設定煮麵時間()
        {
            煮麵時間 = 72.0f;
        }

        public override void 製作拉麵(拉麵訂單 訂單)
        {
            Console.WriteLine("在台灣我們口味略有調整喔");
            base.製作拉麵(訂單);
        }
    }
}