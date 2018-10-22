using System;
/*
Problem 2. Apples or Oranges
*/
class ApplesOrOranges
{
    static void Main()
    {
        long n = Math.Abs(long.Parse(Console.ReadLine()));
        long oddSum = 0;
        long evenSum = 0;
        while (n > 0)
        {
            long digit = n % 10;
            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
            n = n / 10;
        }
        if (evenSum > oddSum)
        {
            Console.WriteLine("apples {0}",evenSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("oranges {0}", oddSum);
        }
        else
        {
            Console.WriteLine("both {0}", evenSum);
        }
    }
}
