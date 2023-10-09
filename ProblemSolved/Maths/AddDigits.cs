using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class AddDigits
    {
        // O(digits)
        public static int GetSumOfDigits(int num)
        {
            if (num == 0)
                return 0;

            int sum = 0;
            int d,temp = num;

            while (temp != 0)
            {
                d = temp % 10;
                sum = sum + d;
                temp = temp / 10;

                if (temp == 0)
                {
                    if (sum / 10 == 0)
                    {
                        return sum;
                    }
                    else
                    {
                        temp = sum;
                        sum = 0;
                    }
                }

            }
            return sum;


        }


        // efficient solution O(1)
        public static int  addDigits(int num)
        {
            if (num == 0) return 0;
            //return num % 9 == 0 ? 9 : num % 9;
            return 1 + (num - 1) % 9;
        }
    }
}
