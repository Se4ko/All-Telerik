using System;
/*
9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Variable values: \n a = {0}\n b = {1}",a,b);

        var temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Variable values after swap: \n a = {0}\n b = {1}", a, b);
    }
}
