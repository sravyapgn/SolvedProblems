using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved.Maths
{
    internal class QuadraticEquationProblems
    {
        public static void DriverProgram()
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                int[] arr = Array.ConvertAll(elements.Split(), int.Parse);// input for array elements
                int a = arr[0];
                int b = arr[1];
                int c = arr[2];
                
                List<int> res = equationRoots(a, b, c);
                int size = res.Count;
                if (size == 1)
                {
                    if (res[0] == 0)
                    {
                        Console.Write("Invalid");
                    }
                    else if (res[0] == -1)
                    {
                        Console.Write("Imaginary");
                    }

                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(res[i] + " ");
                    }
                }
                Console.Write("\n");
            }
        }
        //Complete this function
        public static List<int> equationRoots(int a, int b, int c)
        {

            //Your code here
            int d = b * b - 4 * a * c;
            double sqrt_val = Math.Abs(d);

            List<int> roots = new List<int>();
            double root1 = 0;
            double root2 = 0;

            if (d == 0)
            {
                root1 = -b / (2 * a);
                root2 = root1;

                roots.Add((int)root1);
                roots.Add((int)root2);
            }
            else if (d > 0)
            {
                root1 = (-b + Math.Sqrt(sqrt_val)) / 2 * a;
                root2 = (-b - Math.Sqrt(sqrt_val)) / 2 * a;

                roots.Add((int)root1);
                roots.Add((int)root2);
            }
            else
            {
                Console.WriteLine("Imaginary");
            }
            return roots;
        }
    }
}
