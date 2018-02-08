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
            Console.Write("請輸入National No:");
            int nationalNo = -1;
            // int.TryParse(Console.ReadLine(), out nationalNo);
            try
            {
                nationalNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("National No 輸入錯誤!");
                return;
            }

            Console.Write("請輸入Height:");
            float height = 0.0f;
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("height 輸入錯誤!");
                return;
            }

            Console.WriteLine("National No: {0}", nationalNo);
            Console.WriteLine("Height: {0}", height);
        }
    }
}