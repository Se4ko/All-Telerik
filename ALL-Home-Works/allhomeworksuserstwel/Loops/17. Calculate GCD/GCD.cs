using System;
/*
17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
*/
class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter 2 numbers:");
        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;
        int q = Math.Max(Math.Abs(a), Math.Abs(b));
        int z = Math.Min(Math.Abs(a), Math.Abs(b));
        while (true)
        {
            //q = z * f + r
            int r = q % z;
            q = z;
            z = r;
            if (r == 0)
            {
                gcd = q;
                break;
            }
        }
        Console.WriteLine("The greatest common divisor for {0} and {1} is: {2}", a, b, gcd);
    }
}
