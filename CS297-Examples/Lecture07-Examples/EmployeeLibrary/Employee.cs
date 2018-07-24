using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {

        public string Name { get; set; }
       
        private int salary;

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value > 50000)
                {
                    this.salary = 50000;
                }
                else if (value < 22000)
                {
                    this.salary = 22000;
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(int value)
        {
            if (value > 50000)
            {
                this.salary = 50000;
            }
            else if (value < 22000)
            {
                this.salary = 22000;
            }
            else
            {
                this.salary = value;
            }
        }
    }
}
