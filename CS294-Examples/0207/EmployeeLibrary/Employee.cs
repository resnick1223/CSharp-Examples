using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        #region 欄位

        protected int salary;

        #endregion 欄位

        #region 屬性

        public virtual int Salary
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

        public string Name
        {
            get; set;
        }

        #endregion 屬性

        #region 建構式

        public Employee(string name, int salary)
        {
            this.Salary = salary;
            this.Name = name;
        }

        public Employee() : this("無名氏", 2000)
        {
        }

        #endregion 建構式

        #region 方法

        public override string ToString()
        {
            return string.Format("員工姓名: {0}, 薪資: {1}", this.Name, this.salary);
        }

        #endregion 方法
    }
}