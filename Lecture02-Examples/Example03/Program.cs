using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
                @"select * from Table
                    where id > 10
                    ";
            Console.WriteLine(sql);

            string path = @"C:\xampp\htdoc\";
            Console.WriteLine(path);
        }
    }
}