using System;
/*
5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/
class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for a , it must be from 0 to 500.");
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.WriteLine("Enter value for a , it must be from 0 to 500.");
            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter value for b");
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter value for c");
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|" + Convert.ToString(a, 16).PadRight(10, ' ').ToUpper() + "|" + Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0, 10:F2}|{1, -10:F3}|", b, c);
    }
}
