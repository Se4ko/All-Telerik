using System;
using System.Globalization; // Used so we can input the floating-point values using the numpad( using . and not ,). The program crashes in the Test if Globalisation is not used.
/*
13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
*/
class ComparingFloats
{
    static void Main()
    {
        double a = 4.3;
        double b = 4.4;
        double eps = 0.000001;
        bool checkSum = Math.Abs(a - b) < eps;
        Console.WriteLine(checkSum);

        //Test with user input values
        Console.WriteLine("Please input the first number:");
        double userInputOne = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Please input the secound number:");
        double userInputTwo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        bool checkSum2 = Math.Abs(userInputOne - userInputTwo) < eps;
        Console.WriteLine(checkSum2);
    }
}