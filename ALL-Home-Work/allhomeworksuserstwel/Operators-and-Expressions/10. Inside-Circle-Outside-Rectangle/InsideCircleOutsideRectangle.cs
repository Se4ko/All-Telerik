using System;
/*
10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
class InsideCircleOutsideRectangle
{
    static void Main(string[] args)
    {
        double xCenter = 1;
        double yCenter = 1;
        double r = 1.5;
        Console.WriteLine("Please input x and y values");
        Console.Write("x = ");
        double xCenterP = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double yCenterP = Convert.ToDouble(Console.ReadLine());
        bool insideCircle;
        insideCircle = ((xCenterP - xCenter) * (xCenterP - xCenter) + (yCenterP - yCenter) * (yCenterP - yCenter)) <= (r * r);
        double rTop = 1;
        double rLeft = -1;
        double rWidth = 6;
        double rHeight = 2;
        bool insideRectangle = (xCenterP >= rLeft) && (xCenterP <= (rLeft + rWidth)) && (yCenterP <= rTop) && (yCenterP >= (rTop - rHeight));
        bool outsideRectangle = !insideRectangle;
        bool insideCircleOutsideRectangle = insideCircle && outsideRectangle;
        Console.WriteLine("The given point is inside the circle but outside the rectangle: {0}",insideCircleOutsideRectangle);
    }
}
