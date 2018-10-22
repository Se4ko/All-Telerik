using System;
using System.Numerics;
/*
7. Calculate N! / (K! * (N-K)!)

n combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/
class NandKFactDiv
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ", n - 1);
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {

            BigInteger factN = 1;
            BigInteger factK = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i <= k)
                {
                    factK *= i;
                }
            }
            BigInteger factNK = 1;
            for (int j = 1; j <= n - k; j++)
            {
                factNK *= j;
            }
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", factN / (factK * (factNK)));
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Enter correct values for N and K.\nFollowing this rule (1 < k < n < 100)");
            Main();
        }
    }
}
