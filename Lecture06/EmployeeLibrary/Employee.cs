using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        private string name;
        private int salary;

        #region Getter Setter

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string value)
        {
            this.name = value;
        }

        public int GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(int value)
        {
            if (value > 55000)
                this.salary = 55000;
            else if (value < 23000)
                this.salary = 23000;
            else
                this.salary = value;
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value > 55000)
                    this.salary = 55000;
                else if (value < 23000)
                    this.salary = 23000;
                else
                    this.salary = value;
            }
        }

        #endregion Getter Setter
    }
}