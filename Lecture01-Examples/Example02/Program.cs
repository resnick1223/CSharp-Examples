using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "張元鴻",
                phone = "0910123456",
                address = "台大資工"
            };
            Console.WriteLine(
                "學生姓名:{0}, 電話:{1}, 住址:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address
            );
        }
    }
}