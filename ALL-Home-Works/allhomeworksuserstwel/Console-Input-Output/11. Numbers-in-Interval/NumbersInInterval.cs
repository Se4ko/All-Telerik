using System;
/*
11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers
and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
*/
class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter a starting number A and an end number B:");
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());
        if (b <= a)
        {
            Console.WriteLine("B must be greater than A");
        }
        else
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i);
                    if (i < b)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}