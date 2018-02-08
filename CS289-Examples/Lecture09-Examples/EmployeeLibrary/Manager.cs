using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        public string Title { get; set; }

        public Manager(string name, string title, int salary, int benefit)
            : base(name, salary, benefit)
        {
            Title = title;
        }

        public Manager() : base()
        {
            Title = "小主管";
        }

        public override string Report
        {
            get
            {
                return "主管報表: \n" + base.Report;
            }
        }

        public override int Salary
        {
            get => base.Salary;
            set
            {
                if (value < 40000)
                    salary = 40000;
                else if (value > 80000)
                    salary = 80000;
                else
                    salary = value;
            }
        }
    }
}