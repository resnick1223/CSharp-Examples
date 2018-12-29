using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HttpStatus httpStatus = HttpStatus.SwitchingProtocols;

            switch (httpStatus)
            {
                case HttpStatus.Continue:
                    Console.WriteLine(HttpStatus.Continue);
                    break;

                case HttpStatus.SwitchingProtocols:
                    Console.WriteLine(HttpStatus.SwitchingProtocols);
                    break;

                default:
                    Console.WriteLine("不要亂打");
                    break;
            }
        }
    }
}