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
            寶可夢 寶可夢物件1 = new 寶可夢(1, "妙蛙種子");

            Console.WriteLine(寶可夢物件1.名字);

            寶可夢 寶可夢物件2 = 寶可夢物件1;

            Console.WriteLine(寶可夢物件2.名字);

            寶可夢物件2.編號 = 3;
            Console.WriteLine(寶可夢物件1.編號);
        }
    }
}