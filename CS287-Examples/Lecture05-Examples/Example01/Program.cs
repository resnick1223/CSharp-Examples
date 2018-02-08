using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EventName eventName = (EventName)int.Parse(Console.ReadLine());
            Console.WriteLine(eventName);
            switch (eventName)
            {
                case EventName.ConnectionSuccess:
                    Console.WriteLine("連線成功");
                    break;

                case EventName.ConnectionError:
                    Console.WriteLine("連線失敗");
                    break;

                case EventName.UnknownError:
                    Console.WriteLine("發生未預期錯誤");
                    break;

                default:
                    Console.WriteLine("未知狀態代碼");
                    break;
            }
        }
    }
}