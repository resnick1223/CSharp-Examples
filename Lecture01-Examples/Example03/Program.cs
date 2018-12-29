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
            Student someone = new Student();
            someone.name = "張元鴻";
            Console.WriteLine("學生姓名:{0}", someone.name);
        }
    }
}