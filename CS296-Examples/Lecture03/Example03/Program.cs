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
            string mail = "abc@gmail.com";
            int atPosition = mail.IndexOf("@");
            int dotPosition = mail.IndexOf(".");
            bool isMail =
                (atPosition > 0) &&
                (atPosition < dotPosition) &&
                (dotPosition < mail.Length - 2);

            Console.WriteLine("{0} 是合法的mail嗎? {1}", mail, isMail);
        }
    }
}