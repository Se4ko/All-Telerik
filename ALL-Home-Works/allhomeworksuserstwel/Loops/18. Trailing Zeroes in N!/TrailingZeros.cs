using System;
using System.Numerics;
/*
18.* Trailing Zeros in N!

Write a program that calculates with how many zeros the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/
class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
        }
        BigInteger tZeros = 0;
        for (int j = 1; j > 0; j++)
        {
            BigInteger calculation = n / (BigInteger)Math.Pow(5, j);
            if (calculation == 0)
            {
                break;
            }
            else
            {
                tZeros += calculation;
            }
        }
        string explanation = "";
        if (tZeros < 15)
        {
            explanation = nFact.ToString();
        }
        else
        {
            explanation = "the factorial of N is too big for it to look presentable in the console.";
        }
        Console.WriteLine("The number of trailing zeros is : {0}\nExplanation: {1}", tZeros, explanation);
    }
}
