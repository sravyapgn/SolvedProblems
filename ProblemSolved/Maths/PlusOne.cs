using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class PlusOne
    {
        public static int[] AddplusOne(int[] digits)
        {

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            // for use case arr['9'] to result in arr['1','0']
            int[] resArr = new int[digits.Length + 1];
            resArr[0] = 1;
            return resArr;
        }
    }
}
