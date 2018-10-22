using System;
/*
3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
*/
class MinMaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter the number of integers you want to use.");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        int min = numbers[0];
        int max = numbers[0];
        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("Min = {0}",min);
        Console.WriteLine("Max = {0}",max);
        Console.WriteLine("Sum = {0}",sum);
        Console.WriteLine("Average = {0:0.00}",(double)sum / n);
    }
}
