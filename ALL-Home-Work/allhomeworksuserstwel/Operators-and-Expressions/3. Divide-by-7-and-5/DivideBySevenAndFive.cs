using System;
/*
3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/
class DivideBySevenAndFive
    {
        static void Main()
        {
        Console.WriteLine("Please input some integer value :");
        int userNumber = int.Parse(Console.ReadLine());
        bool number = userNumber % 5 == 0 && userNumber % 7 == 0;
        Console.WriteLine("The given value {0} is devidable by 7 and 5 without a reminder : {1}", userNumber, number);
        }
    }
