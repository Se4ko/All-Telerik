using System;
/*
6. The Biggest of 5 Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/
class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Input values for a b c d e :");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest number is : {0}",a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest number is : {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest number is : {0}", c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest number is : {0}", d);
        }
        else
        {
            Console.WriteLine("The biggest number is : {0}", e);
        }
    }
}
