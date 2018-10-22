using System;
/*
2. Float or Double

Which of the following values can be assigned to a variable of type float and which to a variable of type double:
34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/
class FloatOrDouble
{
    static void Main()
    {
        float floatValueOne = 12.345f;
        float floatValueTwo = 3456.091f;
        double doubleValueOne = 34.567839023;
        double doubleValueTwo = 8923.1234857;

        Console.WriteLine("Values that must be assigned to a float type variable are:\n{0} and {1}",floatValueOne, floatValueTwo);
        Console.WriteLine("Values that must be assigned to a double type variable are:\n{0} and {1}",doubleValueOne,doubleValueTwo);
    }
}
