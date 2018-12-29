using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ScoreOperation
    {
        private OperationAdapter adapter;

        public int[] Sort(int[] scores)
        {
            return adapter.Sort(scores);
        }

        public int Search(int[] scores, int key)
        {
            return adapter.Search(scores, key);
        }
    }
}