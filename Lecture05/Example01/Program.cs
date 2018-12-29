using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int index = 0; index < 10; index++)
            {
                // index 不等於3 的時候 列印 index
                // if (index != 3)
                    // Console.WriteLine(index);

                // 列印index 當index等於3的時候 略過
                if (index == 3)
                    continue;
                Console.WriteLine(index);

            }
        }
    }
}
