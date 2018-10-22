using System;
/*
4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/
class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        Console.Write("A: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("B: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is : {0}",Math.Max(a, b));
    }
}
