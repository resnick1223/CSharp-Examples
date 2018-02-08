using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public abstract class Filter : Plugin, IFilter
    {
        public abstract string ApplyFilter(string image);
    }
}