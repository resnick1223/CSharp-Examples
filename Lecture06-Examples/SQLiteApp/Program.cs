using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.SQLite;

namespace SQLiteApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (!File.Exists(@"C:\Users\Resnick\Desktop\test.db"))
            {
                SQLiteConnection.CreateFile(@"C:\Users\Resnick\Desktop\test");
            }

            SQLiteConnection conn = new SQLiteConnection(@"Data source=C:\Users\Resnick\Desktop\test.db");

            conn.Open();

            // 執行SQL的查詢
        }
    }
}