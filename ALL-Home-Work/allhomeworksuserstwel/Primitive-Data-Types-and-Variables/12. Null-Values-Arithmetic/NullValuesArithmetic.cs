using System;
/*
12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/
class NullValuesArithmetic
{
    static void Main()
    {
        int? variableInt = 5;
        double? variableDouble = 1.7;
        variableInt = null;
        variableDouble = null;
        Console.WriteLine("Integer value:{0}\n Double value:{1}", variableInt, variableDouble);

        variableInt = 10;
        variableDouble = 3.4;
        Console.WriteLine("Integer value:{0}\n Double value:{1}", variableInt, variableDouble);
    }
}
