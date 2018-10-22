using System;
/*
9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please inout the a, b and h for your trapezoid.");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h: ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine("The area of your trapezoid is {0}",area);
    }
}
