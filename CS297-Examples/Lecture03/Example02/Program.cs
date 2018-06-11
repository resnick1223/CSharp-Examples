using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    enum HttpStatus
    {
        OK = 200, NotFound = 404
    }

    enum HardwareStatus
    {
        OK = 200, Error = 404
    }
    class Program
    {
        static void Main(string[] args)
        {
            HardwareStatus myComputerStatus = HardwareStatus.OK;
            HttpStatus websiteStatus = HttpStatus.NotFound;
            Console.WriteLine((int)myComputerStatus);
            Console.WriteLine((int)websiteStatus);
        }
    }
}
