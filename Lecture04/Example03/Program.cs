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
            Random random = new Random();

            int length = 20;
            int count = 0;
            int total = 0;
            for (int index = 0; index < length; index++)
            {
                int number = random.Next(1, 101);
                total = total + number;
                // TODO: 前五個 顯示 {0} +
                if (index >= 0 && index < 5)
                    Console.Write("{0} + ", number);

                // TODO: 第六個 到 倒數第二個 出現一次 ... +
                else if (index >= 5 && index < length - 1)
                {
                    if (count < 1)
                    {
                        Console.Write("...+ ");
                        count++;
                    }
                }

                // TODO: 最後一個 {0} = {1} {0}是最後一個數字 {1} 是總和
                else
                    Console.Write("{0} = {1}", number, total);
            }
        }
    }
}