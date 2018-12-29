using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class TopSales : Sales
    {
        public override string ToString()
        {
            return
                "我是頂級業務\n" +
                base.ToString();
        }
    }
}