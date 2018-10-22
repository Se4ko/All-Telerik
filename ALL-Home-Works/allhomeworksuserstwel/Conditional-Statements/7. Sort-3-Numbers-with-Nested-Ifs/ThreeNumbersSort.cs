using System;
/*
7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
*/
class ThreeNumbersSort
{
    static void Main()
    {
       
        Console.WriteLine("Input values for a b c :");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b) // a > b
        {
            if (b < c)
            {
                if (c > a)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);// c a b
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);// a c b
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);// a b c
            }
        }
        else // a < b
        {
            if (c < a)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);// b a c
            }
            else
            {
                if (c > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);// c b a
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);// b c a
                }
            }
        }
    }
}
