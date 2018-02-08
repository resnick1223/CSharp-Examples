using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderA.SubFolder;

namespace Example01_SwitchCase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入 (1) Continue, (2) SwtchingProtocols, (3) NotFound");

            StatusCode status = (StatusCode)int.Parse(Console.ReadLine());
            Console.WriteLine(status);
        }
    }
}