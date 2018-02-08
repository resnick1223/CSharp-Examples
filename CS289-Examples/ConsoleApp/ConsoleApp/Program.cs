using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.IO;
using System.Data.SQLite;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (!File.Exists(@"C:\Users\Resnick\Desktop\store.db"))
                SQLiteConnection.CreateFile(@"C:\Users\Resnick\Desktop\store.db");
        }
    }
}