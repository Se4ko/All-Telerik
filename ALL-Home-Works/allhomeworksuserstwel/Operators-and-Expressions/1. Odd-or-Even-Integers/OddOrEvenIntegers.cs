using System;
/*
1. Odd or Even Integers

Write an expression that checks if given integer is odd or even.
*/
class OddOrEvenIntegers
{
        static void Main()
        {
        Console.WriteLine("Please input an integer value:" );
        int userIntegerInput = int.Parse(Console.ReadLine());

        if (userIntegerInput % 2 == 0)
            Console.WriteLine("The integer {0} is even", userIntegerInput);

        else
            Console.WriteLine("The integer {0} is odd", userIntegerInput);
        }
    }
