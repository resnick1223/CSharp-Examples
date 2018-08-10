using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 一蘭製造
{
    public class 一蘭拉麵店
    {
        public float 煮麵時間 { get; set; }

        public 一蘭拉麵店()
        {
            設定煮麵時間();
        }

        public virtual void 製作拉麵(拉麵訂單 訂單)
        {
            準備麵條();
            煮麵(訂單.麵的軟硬);
            製作湯頭(訂單);
            加上配料(訂單);
        }

        protected void 準備麵條()
        {
            Console.WriteLine("準備麵條");
        }

        protected virtual void 設定煮麵時間()
        {
            煮麵時間 = 90.0f;
        }

        protected void 煮麵(int 麵的軟硬度)
        {
            煮麵時間 *= (麵的軟硬度 / 3.0f);

            switch (麵的軟硬度)
            {
                case 1:
                    Console.WriteLine("客人要求:超硬, 煮麵時間設定為{0}秒", 煮麵時間);
                    break;

                case 2:
                    Console.WriteLine("客人要求:硬, 煮麵時間設定為{0}秒", 煮麵時間);
                    break;

                case 3:
                    Console.WriteLine("客人要求:普通, 煮麵時間設定為{0}秒", 煮麵時間);
                    break;

                case 4:
                    Console.WriteLine("客人要求:軟, 煮麵時間設定為{0}秒", 煮麵時間);
                    break;

                case 5:
                    Console.WriteLine("客人要求:超軟, 煮麵時間設定為{0}秒", 煮麵時間);
                    break;
            }
        }

        protected void 製作湯頭(拉麵訂單 訂單)
        {
            switch (訂單.口味濃淡)
            {
                case 1:
                    Console.WriteLine("口味濃淡，客人要求:清淡");
                    break;

                case 2:
                    Console.WriteLine("口味濃淡，客人要求:普通");
                    break;

                case 3:
                    Console.WriteLine("口味濃淡，客人要求:濃郁");
                    break;
            }

            switch (訂單.油濃郁度)
            {
                case 1:
                    Console.WriteLine("油濃郁度，客人要求:清淡");
                    break;

                case 2:
                    Console.WriteLine("油濃郁度，客人要求:普通");
                    break;

                case 3:
                    Console.WriteLine("油濃郁度，客人要求:濃郁");
                    break;

                case 4:
                    Console.WriteLine("油濃郁度，客人要求:軟");
                    break;

                case 5:
                    Console.WriteLine("油濃郁度，客人要求:超軟");
                    break;
            }

            switch (訂單.蒜泥)
            {
                case 0.0f:
                    Console.WriteLine("蒜泥，客人要求:無");
                    break;

                case 0.1f:
                    Console.WriteLine("蒜泥，客人要求:少許");
                    break;

                case 0.2f:
                    Console.WriteLine("蒜泥，客人要求:普通");
                    break;

                case 0.5f:
                    Console.WriteLine("蒜泥，客人要求:1/2片");
                    break;

                case 1.0f:
                    Console.WriteLine("蒜泥，客人要求:1片");
                    break;
            }
        }

        protected void 加上配料(拉麵訂單 訂單)
        {
        }
    }
}