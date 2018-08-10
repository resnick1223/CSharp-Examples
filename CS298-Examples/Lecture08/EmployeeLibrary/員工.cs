using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class 員工
    {
        public int 編號 { get; set; }
        public string 姓名 { get; set; }
        public int 薪水 { get; set; }

        public void 列印薪資單()
        {
            Console.WriteLine("姓名:{0}, 薪水:新台幣{1}元", 姓名, 薪水);
        }
    }
}