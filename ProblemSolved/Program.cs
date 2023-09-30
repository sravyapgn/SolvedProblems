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

//Console.WriteLine("Given an integer num, return the number of steps to reduce it to zero.\r\n\r\nIn one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.");
//Console.WriteLine(obj.NumberOfSteps(Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("You are given a positive integer num consisting of exactly four digits. Split num into two new integers new1 and new2 by using the digits found in num. Leading zeros are allowed in new1 and new2, and all the digits found in num must be used.");
Console.WriteLine("For example, given num = 2932, you have the following digits: two 2's, one 9 and one 3. Some of the possible pairs [new1, new2] are [22, 93], [23, 92], [223, 9] and [2, 329].");
Console.WriteLine("Return the minimum possible sum of new1 and new2.");
Console.WriteLine(obj.MinimumSum(Convert.ToInt32(Console.ReadLine())));






