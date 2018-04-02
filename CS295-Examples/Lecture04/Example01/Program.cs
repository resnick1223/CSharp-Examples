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
            int? statusNo = null;
            Console.Write("請輸入一個狀態編號:");
            try
            {
                statusNo = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤! 系統訊息為:\n{0}", e.StackTrace);
            }

            switch (statusNo)
            {
                case 1:
                    Console.WriteLine("Status Code: 1, Success");
                    break;

                case 2:
                    Console.WriteLine("Status Code: 2, Something wrong");
                    break;

                default:
                    if (statusNo == null)
                        Console.WriteLine("狀態編號尚未設定");
                    else
                        Console.WriteLine("無此狀態，請重新輸入");
                    break;
            }
        }
    }
}