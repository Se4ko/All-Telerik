using System;
/*
6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
*/
class FourDigitNumber
{
        static void Main()
        {
        Console.WriteLine("Please input your four digit number.");
        int givenNumber = int.Parse(Console.ReadLine());
        int a = givenNumber / 1000;
        int b = givenNumber / 100 % 10;
        int c = givenNumber / 10 % 10;
        int d = givenNumber % 10;

        int sumOfDigits = a + b + c + d;
        Console.WriteLine("The sum of the digits of your number \"{0}\" is {1}",givenNumber, sumOfDigits);
        Console.WriteLine("The reversed order of your number \"{0}\" is {1}{2}{3}{4}",givenNumber,d,c,b,a);
        Console.WriteLine("If we swap the first and last digits of \"{0}\" it would look like this {1}{2}{3}{4}",givenNumber,d,b,c,a);
        Console.WriteLine("If we swap the second and thirt digits of \"{0}\" it would look like this {1}{2}{3}{4}", givenNumber, a, c, b, d);
    }
    }
