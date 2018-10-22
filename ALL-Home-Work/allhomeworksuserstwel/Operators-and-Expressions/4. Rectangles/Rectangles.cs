using System;
/*
4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/
class Rectangles
    {
        static void Main()
        {
        Console.WriteLine("Whats the width and height of your rectangle:");
        Console.Write("Hight:");
        float hight = float.Parse(Console.ReadLine());
        Console.Write("Width:");
        float width = float.Parse(Console.ReadLine());
        float perimeter = 2 * (hight + width); //P = 2 * ( H + W )
        float area = hight * width; // A = H * W
        Console.WriteLine("The perimeter of your rectangle is {0} and the area is {1} .", perimeter, area);
        }
    }
