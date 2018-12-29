using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            飲料元件 美式 = new 美式咖啡();

            美式.操作();
            Console.WriteLine("----------");
            美式 = new 豆漿(美式);

            美式.操作();

            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = new 豆漿(美式);

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = new 牛奶(美式);

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = new 多冰(美式);

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = (美式 as 飲料裝飾者).取消();

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = (美式 as 飲料裝飾者).取消();

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);

            Console.WriteLine("----------");
            美式 = (美式 as 飲料裝飾者).取消();

            美式.操作();
            Console.WriteLine("咖啡價格:{0}", 美式.價格);
        }
    }
}