using System;
/*
1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
*/
class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers.");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum of {0} + {1} + {2} is : {3}",a,b,c,sum);
    }
}
