// See https://aka.ms/new-console-template for more information
using ProblemSolved;

Console.WriteLine("Hello, World!");
MathProblems obj = new MathProblems();

//Console.WriteLine("Enter number to reverse ");
//Console.WriteLine(obj.Reverse(Convert.ToInt32(Console.ReadLine())));

//Console.WriteLine("Enter number to reverse ");
//Console.WriteLine(obj.IsPalindrome(Convert.ToInt32(Console.ReadLine())));

//Console.WriteLine("Given an integer n, return the number of trailing zeroes in n!.");
//Console.WriteLine(obj.TrailingZeroes(Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("Given an integer num, return the number of steps to reduce it to zero.\r\n\r\nIn one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.");
Console.WriteLine(obj.NumberOfSteps(Convert.ToInt32(Console.ReadLine())));

