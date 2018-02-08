using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 建立學生物件
            Student someone = new Student()
            {
                id = 1,
                name = "resnick",
                birthday = "12/23",
                email = "resnick1223@gmail.com"
            };
            Console.WriteLine(someone.email);
        }
    }
}