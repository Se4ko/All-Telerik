using System;
/*
10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the 
Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
*/
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int cTemp;
        for (int i = 0; i < n;)
        {
            Console.Write(a + ", ");
            cTemp = a; // Old number
            a = b; //New Number
            b = cTemp + b; //Future number for next loop ( The old old value of a + the value of b)

            i++;
        }
    }
}
