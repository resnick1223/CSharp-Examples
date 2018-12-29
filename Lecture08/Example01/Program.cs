using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入員工姓名:");
            string name = Console.ReadLine();

            Console.Write("請輸入員工底薪:");
            int baseSalary = int.Parse(Console.ReadLine());
            Employee employee = new Employee();
            employee.name = name;
            employee.BaseSalary = baseSalary;
            employee.BaseSalary = 10000000;
            employee.Benefit = 100000;
            Console.WriteLine(employee.Salary);
        }
    }
}