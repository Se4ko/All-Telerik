using System;
using System.Numerics;
/*
8. Catalan Numbers

Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factTwoN = 1;
        BigInteger factNPlusOne = 1;
        if (0 <= n && n <= 100)
        {
            for (int i = 1; i <= n * 2; i++)
            {
                factTwoN *= i;
                if (i <= n)
                {
                    factN *= i;
                }
            }
            for (int j = 1; j <= n + 1; j++)
            {
                factNPlusOne *= j;
            }
            Console.WriteLine("Catalan(n): {0}", factTwoN / (factN * factNPlusOne));
        }
        else
        {
            Console.WriteLine("The value of N must be from 0 to 100.");
            Main();
        }
    }
}
