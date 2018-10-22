using System;
/*
6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine());

        double Discriminant = (b * b) - 4 * a * c;
        if (Discriminant > 0)
        {
            double xOne = (-b + Math.Sqrt(Discriminant)) / (2 * a);
            double xTwo = (-b - Math.Sqrt(Discriminant)) / (2 * a);
            Console.WriteLine("The discriminant is positive so we get TWO real solutions :\nx1 = {0} and x2= {1}", xOne, xTwo);
        }
        else if (Discriminant == 0)
        {
            double xOne = (-b + Math.Sqrt(Discriminant)) / (2 * a);
            Console.WriteLine("The discriminant in the formula is 0 so we get only one real solution. x = {0}",xOne);
        }
        else
        {
            Console.WriteLine("Invalid roots.");
        }
    }
}
