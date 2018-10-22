using System;
/*
Problem 1. Coffee Machine
*/
class CoffeeMachine
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine()); //0.05
        int n2 = int.Parse(Console.ReadLine()); //0.10
        int n3 = int.Parse(Console.ReadLine()); //0.20
        int n4 = int.Parse(Console.ReadLine()); //0.50
        int n5 = int.Parse(Console.ReadLine()); //1.00
        double a = double.Parse(Console.ReadLine()); // Money  Put
        double p = double.Parse(Console.ReadLine()); // Price
        double moneyInside = (n1 * 0.05) + (n2 * 0.10) + (n3 * 0.20) + (n4 * 0.50) + (n5 * 1.00);
        double changeToGive = a - p;
        if (a >= p && changeToGive <= moneyInside) //Yes or Exact
        {
            Console.WriteLine("Yes {0:0.00}",moneyInside - changeToGive);
        }
        else if (a < p )
        {
            Console.WriteLine("More {0:0.00}",p - a);
        }
        else if (a > p && changeToGive > moneyInside)
        {
            Console.WriteLine("No {0:0.00}",changeToGive - moneyInside );
        }
    }
}
