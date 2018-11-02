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
            // TODO 宣告一個變數 儲存總和
            int total = 0;
            int max = 1001;
            int count = 0;
            // TODO 宣告一個變數 作為 號碼牌
            for (int next = 1; next <= max; next += 2)
            {
                total += next;
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine(total);
        }
    }
}