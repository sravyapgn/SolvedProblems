using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved
{
    internal class ReverseInteger64BitCheck
    {
        public int Reverse(int x)
        {
            if (x < 0 && (long)x * -1l > Int32.MaxValue)
            {
                return 0;
            }
            int rev = 0;
            int digit = 0;

            int tmp = x < 0 ? x * -1 : x;
            while (tmp != 0)
            {
                digit = tmp % 10;
                rev = (rev * 10) + digit;
                tmp = tmp / 10;
                if (tmp > 0)
                {
                    // 2nd overflow checking...
                    if ((long)rev * 10l > Int32.MaxValue)
                    {
                        return 0;
                    }
                }
            }
            return x < 0 ? rev * -1 : rev;
        }
    }
}
