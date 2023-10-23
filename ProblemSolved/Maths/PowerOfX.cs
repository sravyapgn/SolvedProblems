using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class PowerOfX
    {
        /* Function to calculate x raised to the power y */
        public static int Power(int x, int y)
        {
            int temp;

            if(y==0)
            {
                return 1;
            }

            temp = Power(x, y / 2);

            if (y % 2 == 0)
            {
                return temp * temp;
            }
            else
                return x * temp * temp;
        }
    }
}
