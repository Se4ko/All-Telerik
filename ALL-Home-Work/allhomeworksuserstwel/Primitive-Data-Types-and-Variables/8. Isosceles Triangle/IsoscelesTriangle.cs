using System;
using System.Text;
/*
8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
*/
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';
        Console.SetCursorPosition(4, 0);
        Console.Write(copyright);
        Console.SetCursorPosition(3, 1);
        Console.Write(copyright);
        Console.SetCursorPosition(5, 1);
        Console.Write(copyright);
        Console.SetCursorPosition(2, 2);
        Console.Write(copyright);
        Console.SetCursorPosition(6, 2);
        Console.Write(copyright);
        Console.SetCursorPosition(1, 3);
        Console.Write(copyright);
        Console.SetCursorPosition(3, 3);
        Console.Write(copyright);
        Console.SetCursorPosition(5, 3);
        Console.Write(copyright);
        Console.SetCursorPosition(7, 3);
        Console.Write(copyright);
    }
}
