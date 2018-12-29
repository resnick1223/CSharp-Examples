using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        protected int salary;
        private string name;
        protected int benefit;

        public Employee(string name, int salary, int benefit)
        {
            Name = name;
            Salary = salary;
            Benefit = benefit;
        }

        public Employee() : this("尚未輸入名稱", 22000, 0)
        {
        }

        public virtual int Salary
        {
            get => salary;

            set
            {
                if (value < 22000)
                    salary = 22000;
                else if (value > 50000)
                    salary = 50000;
                else
                    salary = value;
            }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Benefit
        {
            get => benefit;
            set => benefit = value;
        }

        public virtual string Report
        {
            get
            {
                string report = string.Format("員工姓名:{0}，薪資:{1}，獎金:{2}", Name, Salary, Benefit);
                return report;
            }
        }

        public override string ToString()
        {
            return Report;
        }
    }
}