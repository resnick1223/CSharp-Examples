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
            Student student = new Student();
            student.name = "王亭蓓";
            student.contacts = new List<Contact>();
            student.contacts.Add(new Contact()
            {
                phone = "0912345678",
                email = "resnick1223@gmail.com",
                address = "台大"
            });

            Teacher teacher = new Teacher();
            teacher.name = "帽子哥";

            Teacher teacher2 = new Teacher();
        }
    }
}