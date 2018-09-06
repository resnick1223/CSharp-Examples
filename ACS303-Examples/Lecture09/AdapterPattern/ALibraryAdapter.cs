using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class ALibraryAdapter : OperationAdapter
    {
        private SortOperation sortOperation;
        private SearchOperation searchOperation;

        public override int Search(int[] scores, int key)
        {
            double[] doubleScores = new double[scores.Length];
            for (int index = 0; index < scores.Length; index++)
                doubleScores[index] = scores[index];
            return (int)searchOperation.BinarySearch(doubleScores, key);
        }

        public override int[] Sort(int[] scores)
        {
            throw new NotImplementedException();
        }
    }
}