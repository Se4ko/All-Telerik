using System;
/*
11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max)
and prints n random numbers in the range [min...max].
*/
class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Enter the number of random numbers you want the MIN and MAX value of the number range.");
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Max: ");
        int max = int.Parse(Console.ReadLine());
        while (min >= max || max <= min)
        {
            Console.WriteLine("The value of MAX must be bigger than that of MIN\nMax:");
            max = int.Parse(Console.ReadLine());
        }
        Random rNums = new Random();
        for (int i = 0; i < n; i++)
        {
            int someRandomNumber = rNums.Next(min, max + 1);
            Console.Write("{0} ", someRandomNumber);
        }
    }
}
