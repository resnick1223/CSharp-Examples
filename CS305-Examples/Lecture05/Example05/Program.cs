using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example05.Http;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StatusCode status = (StatusCode)101;

            switch (status)
            {
                case StatusCode.A:
                    Console.WriteLine("你輸入的是A");
                    break;

                case StatusCode.B:
                    Console.WriteLine("你輸入的是B");
                    break;

                case StatusCode.C:
                    Console.WriteLine("你輸入的是C");
                    break;

                default:
                    Console.WriteLine("你白癡阿，沒這個東西");
                    break;
            }
        }
    }
}