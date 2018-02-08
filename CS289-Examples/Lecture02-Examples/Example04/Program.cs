using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Users\resnick\Desktop\test.cs";
            string sql = @"select * from table
where id = 1
order by id;";
            Console.WriteLine(sql);
        }
    }
}