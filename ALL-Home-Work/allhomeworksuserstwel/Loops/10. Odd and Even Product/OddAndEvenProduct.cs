using System;
/*
10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/
class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter the integer values you want to use, with a space between each one.");
        string[] numbers = Console.ReadLine().Split(' ');
        int sumOfEven = 1;
        int sumOfOdd = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumOfOdd *= int.Parse(numbers[i]);
            }
            else
            {
                sumOfEven *= int.Parse(numbers[i]);
            }
        }
        if (sumOfEven == sumOfOdd)
        {
            Console.WriteLine("Yes the product is: {0}",sumOfEven);
        }
        else
        {
            Console.WriteLine("No\nProduct of even: {0}\nProduct of odd: {1}", sumOfEven,sumOfOdd);
        }
        Main();
    }
}
