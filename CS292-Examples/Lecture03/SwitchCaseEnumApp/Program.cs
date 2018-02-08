using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseEnumApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StatusCode status = (StatusCode)int.Parse(Console.ReadLine());
            switch (status)
            {
                case StatusCode.Continue:
                    Console.WriteLine("狀態100啦");
                    break;

                case StatusCode.SwitchingProtocols:
                    Console.WriteLine("狀態101啦");
                    break;

                default:
                    Console.WriteLine("好好輸入好嗎?");
                    break;
            }
        }
    }
}