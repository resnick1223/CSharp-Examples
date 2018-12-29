using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        #region 欄位與屬性的定義

        public string Id { get; set; }

        public string Name { get; set; }

        public int BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value < 25000)
                    baseSalary = 25000;
                else if (value > 60000)
                    baseSalary = 60000;
                else
                    baseSalary = value;
            }
        }

        public int Benefit
        {
            get => benefit;
            set
            {
                benefit = value < 0 ? 0 : value;
            }
        }

        public int Salary
        {
            get
            {
                return baseSalary + benefit;
            }
        }

        private int baseSalary;
        private int benefit;

        #endregion 欄位與屬性的定義

        #region 建構式

        public Employee()
            : this("無名氏", 0, 0)

        {
        }

        public Employee(
            string name, int baseSalary, int benefit)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Benefit = benefit;
        }

        #endregion 建構式
    }
}