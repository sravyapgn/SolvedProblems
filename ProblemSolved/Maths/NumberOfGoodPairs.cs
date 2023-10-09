using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class NumberOfGoodPairs
    {
        public static  int GetNumberOfGoodPairs(int[] goodPairs)
        {
            int result = 0;
            int[] pairCounterArray = new int[goodPairs.Length];

            foreach (int i in goodPairs)
            {
                pairCounterArray[i]++;
            }

            foreach(int i in pairCounterArray) 
            {
                // nCr
                result += (i * (i - 1)) / 2;
            }
            return result; 
        }
    }
}
