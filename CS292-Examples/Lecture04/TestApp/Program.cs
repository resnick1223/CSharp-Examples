using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student()
            {
                Email = "resnick1223@gmail.com",
                Phone = "0910123456",
                CurrentLocation = new Location()
                {
                    X = 3,
                    Y = 0
                }
            }; // 新增一個學生 建立一個學生[物件]

            Console.WriteLine(student.CurrentLocation.X);

            student.MoveForward(200);
            Console.WriteLine(student.CurrentLocation.X);
        }
    }
}