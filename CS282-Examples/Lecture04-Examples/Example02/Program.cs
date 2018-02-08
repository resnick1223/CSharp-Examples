using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal enum Status
    { Success = 403, Error = 405, SomeStatus }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Status httpResponse = Status.Error;
            Console.WriteLine(httpResponse);
            Console.WriteLine((int)httpResponse);
            Console.WriteLine((int)Status.SomeStatus);
        }
    }
}