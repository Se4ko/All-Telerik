using System;
/*
5. Third Digit is 7

Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/
class ThirdDigitIsSeven
    {
        static void Main()
        {
        Console.WriteLine("Please input a number.");
        int yourNumber = int.Parse(Console.ReadLine());

        if (yourNumber / 100 % 10 == 7)
            Console.WriteLine("True the third digit right to left is 7");
        else
            Console.WriteLine("False the third digit right to left is not seven");
        }
    }
