using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入帳號:");
            string username = Console.ReadLine();
            Console.WriteLine("您輸入的帳號是{0}", username);

            Student student = new Student();
            Console.Write("請輸入學生姓名:");
            student.Name = Console.ReadLine();
            Console.Write("請輸入學生電話:");
            student.Phone = Console.ReadLine();
            Console.Write("請輸入學生住址:");
            student.Address = Console.ReadLine();

            Console.WriteLine("學生 姓名:{0}, 電話:{1}, 住址:{2}",
                student.Name,
                student.Phone,
                student.Address
            );
        }
    }
}