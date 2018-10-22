using System;
/*
1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers 
from 1 to n, on a single line, separated by a space.
*/
class NNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine("N needs to be bigger or equal to 1");
            Main();
        }
        for (int i = 1; i <= n; i++)
        {
            if (i < n)
            {
                Console.Write(i + " ");
            }
            else
            {
                Console.Write(i);
            }
        }
    }
}
