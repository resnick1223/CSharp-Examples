using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Name = "掃地工", Salary = 100000 };

            // 向上轉型
            Employee employee2 = new Manager { Name = "臭主管", Salary = 40000 };
            
            // 向下轉型
            employee1.Print();
            employee2.Print();
            (employee2 as Manager).Print();

        }
    }
}
