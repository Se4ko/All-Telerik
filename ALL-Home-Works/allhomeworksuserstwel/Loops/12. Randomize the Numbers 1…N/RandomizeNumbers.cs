using System;
using System.Collections.Generic;
/*
12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
*/
class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the vlaue of N:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }
        List<int> randomNumbers = new List<int>(n);
        Random randNumber = new Random();
        while (randomNumbers.Count < n)
        {
            int numForList = randNumber.Next(0, n);
            if (!randomNumbers.Contains(numForList))
            {
                randomNumbers.Add(numForList);
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", numbers[randomNumbers[i]]);
        }
    }
}
