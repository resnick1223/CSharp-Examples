using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee someone = new Employee();
            someone.SetName("帽子哥");
            Console.WriteLine(someone.GetName());
            someone.Salary = 10000;
            Console.WriteLine(someone.Salary);
        }
    }
}