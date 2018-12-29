using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example01.Enums;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StatusCode status = StatusCode.Continue;

            switch (status)
            {
                case StatusCode.Continue:
                    Console.WriteLine("Continue");
                    break;

                case StatusCode.SwtichingProtocols:
                    Console.WriteLine("SwtichingProtocols");
                    break;

                default:
                    Console.WriteLine("還不知道怎麼做");
                    break;
            }
        }
    }
}