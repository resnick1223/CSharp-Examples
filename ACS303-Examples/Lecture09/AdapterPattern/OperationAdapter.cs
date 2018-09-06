using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public abstract class OperationAdapter
    {
        public abstract int[] Sort(int[] scores);

        public abstract int Search(int[] scores, int key);
    }
}