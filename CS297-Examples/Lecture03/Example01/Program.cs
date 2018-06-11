using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.Write("請輸入狀態代碼: ");
                GetResponse(Console.ReadLine());
            }
            else
            {
                GetResponse(args[0]);
            }

           // GetResponse(args.Length == 0 ? Console.ReadLine() : args[0]);
            
        }

        static void GetResponse(string input) 
        {
            int? statusCode = null;
            try
            {
                statusCode = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("輸入的格式不正確");
                return;
            }

            switch (statusCode)
            {

                case 404:
                    Console.WriteLine("找不到網頁喔");
                    break;
                case 200:
                    Console.WriteLine("OK");
                    break;
                default:
                    Console.WriteLine("我聽不懂你說什麼");
                    break;
            }
        }
    }
}
