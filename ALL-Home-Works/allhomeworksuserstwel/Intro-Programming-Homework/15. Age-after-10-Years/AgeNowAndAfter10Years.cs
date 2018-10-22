using System;
/*
15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/
class AgeNowAndAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Hello can you tell me when you ware born ? Please use the DD/MM/YYYY format.");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int currentage = today.Year - birthday.Year;
        if (birthday.Date.DayOfYear < today.Date.DayOfYear)
        {
            Console.WriteLine("Your current age is {0}, and after precisely 10 years from now on you will be {1}.", currentage, currentage + 10);
        }
        else
        {
            Console.WriteLine("Your current age is {0}, and after precisely 10 years from now on you will be {1}.", currentage - 1, currentage + 9);
        }

    }
}
