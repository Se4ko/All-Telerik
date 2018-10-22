using System;
/*
10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.
*/
class BeerTime
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the time you wish to check in the following format \"hh:mm tt\", \nExample 1: 1:14 am\nExample 2: 11:45 pm");
            string time = Console.ReadLine();
            DateTime usertime = DateTime.Parse(time);
            usertime.ToString("hh:mm tt");
            DateTime startTime = DateTime.Parse("01:00 PM");
            DateTime endTime = DateTime.Parse("03:00 AM");
            if (usertime >= startTime || usertime < endTime)
            {
                Console.WriteLine("Its beer time!!!");
            }
            else
            {
                Console.WriteLine("Not beer time, yet ;(");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input, try again.");
            Main();
        }
    }
}
