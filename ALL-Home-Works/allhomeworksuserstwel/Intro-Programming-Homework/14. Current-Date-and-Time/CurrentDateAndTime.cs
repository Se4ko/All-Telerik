using System;
/*
14.* Current Date and Time

Create a console application that prints the current date and time. Find out how in Internet.
*/
class CurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine("The date today is {0} , and its currently {1} .",DateTime.Today.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"));
    }
}