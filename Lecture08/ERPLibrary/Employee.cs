using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPLibrary
{
    public class Employee
    {
        public string name;
        private int baseSalary;

        public int BaseSalary
        {
            get
            {
                return this.baseSalary;
            }

            set
            {
                if (value < 22000)
                {
                    baseSalary = 22000;
                }
                else if (value > 60000)
                {
                    baseSalary = 60000;
                }
                else
                {
                    baseSalary = value;
                }
            }
        }

        private int benefit;

        public int Benefit
        {
            get
            {
                return this.benefit;
            }

            set
            {
                this.benefit = value >= 0 ? value : 0;
            }
        }

        public int Salary
        {
            get
            {
                return this.BaseSalary + this.Benefit;
            }
        }
    }
}