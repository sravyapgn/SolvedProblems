// See https://aka.ms/new-console-template for more information
using ProblemSolved;

Console.WriteLine("Hello, World!");
MathProblems obj = new MathProblems();
Console.WriteLine("Enter number to reverse ");

Console.WriteLine(obj.Reverse(Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("Enter number to reverse ");
Console.WriteLine(obj.IsPalindrome(Convert.ToInt32(Console.ReadLine())));

