using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入您要的狀態編號:");
            int statusNumber = int.Parse(Console.ReadLine());
            Console.WriteLine((SomeStatus)statusNumber);
        }
    }
}