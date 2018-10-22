using System;
/*
5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/
class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Input values for a b c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (b <= c)
            {
                if (c > a)
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
        }
        else
        {
            if (b >= c)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }
}
