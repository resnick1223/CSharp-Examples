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
            Employee employee =
                new Employee("張元鴻", 22000, 10000);
            Console.WriteLine(employee.Salary);
        }
    }
}