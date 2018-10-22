using System;
/*
6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/
class CalculateNDivK
{
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K: ",n - 1);
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {

            int factN = 1;
            int factK = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if (i <= k)
                {
                    factK *= i;
                }
            }
            Console.WriteLine("n! / k! = {0}",factN / factK);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Enter correct values for N and K.\nFollowing this rule (1 < k < n < 100)");
            Main();
        }
    }
}
