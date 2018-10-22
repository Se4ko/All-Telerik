using System;
/*
7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/
class SumOfFive
{
    static void Main()
    {
        Console.Write("Enter 5 numbers separated by a single whitespace: ");
        string[] numbers = Console.ReadLine().Split();
        double a = double.Parse(numbers[0]);
        double b = double.Parse(numbers[1]);
        double c = double.Parse(numbers[2]);
        double d = double.Parse(numbers[3]);
        double e = double.Parse(numbers[4]);

        double sum = a + b + c + d + e;
        Console.WriteLine("The sum of the given numbers is: {0}", sum);
    }
}
