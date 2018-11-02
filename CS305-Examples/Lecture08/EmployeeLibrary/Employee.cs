using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string name;

        #region Salary 欄位與屬性

        private int salary;

        public int GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(int value)
        {
            if (value > 50000)
                this.salary = 50000;
            else if (value < 22000)
                this.salary = 22000;
            else
                this.salary = value;
        }

        #endregion Salary 欄位與屬性
    }
}