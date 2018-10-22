using System;
/*
3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/
class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Radius value:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * (radius * radius);
        Console.WriteLine("Radius : {0} , Perimeter : {1:F2} , Area : {2:F2} .",radius, perimeter, area);
    }
}
