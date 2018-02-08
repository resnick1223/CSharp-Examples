using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
            @"
            select * from table
            where id > 10
            ";
            Console.WriteLine(sql);

            string path = @"C:\CS287-Examples\Lecture01-Examples\Example01\bin";
            Console.WriteLine(path);
        }
    }
}