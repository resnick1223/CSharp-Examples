using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("建立第一隻寶可夢");

            寶可夢 寶可夢1 = new 寶可夢();

            寶可夢1.編號 = int.Parse(Console.ReadLine());
            寶可夢1.名稱 = Console.ReadLine();

            Console.WriteLine("建立第二隻寶可夢");
            寶可夢 寶可夢2 = new 寶可夢();

            寶可夢2.編號 = int.Parse(Console.ReadLine());
            寶可夢2.名稱 = Console.ReadLine();
        }
    }
}