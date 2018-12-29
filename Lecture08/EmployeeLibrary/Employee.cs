using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        // 公開的東西 都是屬性
        // 自動屬性 不需要先訂欄位 如果欄位不需要檢查的話
        // 編譯後 自動產生欄位 不用先訂欄位
        public string Name { get; set; }

        #region Salary 欄位與屬性

        private int salary;

        /// <summary>
        /// Salary 薪資屬性 範圍是22000~50000
        /// </summary>
        public int Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value > 50000)
                    this.salary = 50000;
                else if (value < 22000)
                    this.salary = 22000;
                else
                    this.salary = value;
            }
        }

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