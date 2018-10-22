using System;
/*
7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/
class PointInACircle
{
    static void Main()
    {
        double xCenter = 0.0;
        double yCenter = 0.0;
        double r = 2.0;
        Console.WriteLine("Please input x and y values");
        Console.Write("x = ");
        double xCenterP = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double yCenterP = Convert.ToDouble(Console.ReadLine());
        bool inside;
        inside = ((xCenterP - xCenter) * (xCenterP - xCenter) + (yCenterP - yCenter) * (yCenterP - yCenter)) <= (r * r);
        Console.WriteLine(inside);

        /*
    Can also be done with the shorter formula version considering that the given values of xCenter and yCenter are 0,0 for each one.
    insidee = (xCenterP * xCenterP) + (yCenterP * yCenterP) <= (r * r); 
        */
    }
}
