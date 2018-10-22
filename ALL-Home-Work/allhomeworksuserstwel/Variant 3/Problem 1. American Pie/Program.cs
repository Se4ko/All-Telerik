using System;
/*
Problem 1. American Pie
*/
class AmericanPie
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int denominator = b * d;
        int numerator = (a * d) + (c * b);

        if (numerator / denominator != 0)
        {
            Console.WriteLine(numerator / denominator);
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }
        else
        {
            decimal result = (decimal)numerator / (decimal)denominator;
            Console.WriteLine("{0:F20}",result);
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }
    }
}
