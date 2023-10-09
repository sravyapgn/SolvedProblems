using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class CountPrimes
    {
        public static int CountAllPrimes(int n)
        {
            int counter = 0;
            for (int i = 2; i < n; i++)
            {
                if (CheckPrime(i))
                { 
                    counter++;
                    Console.WriteLine(i);
                }
            }
            return counter;
        }

        public static bool CheckPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i = i + 6)
            {
                if (n % i == 0 || (n % (i + 2)) == 0)
                    return false;
             }
             
            return true;
         }

        }
    
}
