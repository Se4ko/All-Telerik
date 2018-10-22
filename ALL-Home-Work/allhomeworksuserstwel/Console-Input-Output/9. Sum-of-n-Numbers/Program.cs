using System;
/*
9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
*/
class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the value of N");
        int n = int.Parse(Console.ReadLine());
        double sumOfAllN = 0.0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a new number: ");
            double newNumber = double.Parse(Console.ReadLine());
            sumOfAllN += newNumber;
        }
        Console.WriteLine("The sum of all the numbers is {0}", sumOfAllN);
    }
}
