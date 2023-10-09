using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class GCDAndLCM
    {
        public static int GrestestCommonDivisor(int num1, int num2)
        {
            int Remainder=0;
            while (num2!=0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }
            return num1;

            //if (num2 == 0)
            //{
            //    return num1;
            //}
            //else
            //{
            //    return GrestestCommonDivisor(num1, num2 % num1);
            //}

        }

        public static int LCM(int num1, int num2)
        {
            return (num1 * num2)/GrestestCommonDivisor(num1, num2);

        }
    }
}
