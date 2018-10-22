using System;
/*
5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
*/
class CalculateFacN
{
    static void Main()
    {
        Console.Write("N: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("X: ");
        double x = double.Parse(Console.ReadLine());
        double Sum = 1;
        int factN = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            Sum += ( factN / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}",Sum);
    }
}
