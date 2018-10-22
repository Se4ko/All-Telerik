using System;
/*
9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix
like in the examples. Use two nested loops.
*/
class SimpleMatrix
{
    static void Main()
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());
        int gN = 1;
        if (1 <= n && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                gN = i;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ",gN);
                    gN++;
                    if (j == n - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("The number must be from 1 to 20. Try again.");
            Main();
        }
    }
}
