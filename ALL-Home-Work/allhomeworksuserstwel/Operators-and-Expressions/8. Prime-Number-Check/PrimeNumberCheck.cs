using System;
/*
8. Prime Number Check

Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/
class PrimeNumberCheck
    {
        static void Main()
        {
        Console.WriteLine("Please input a number from 1 to 100.");
        int primeTest = int.Parse(Console.ReadLine());
        bool numberCheck = primeTest >= 1 && primeTest <= 100;
        if (primeTest == 1)
        {
            Console.WriteLine("Is \"{0}\" a prime number: {1}", primeTest, false);
        }
        else
        {
            bool primeNumber = true;
            if (numberCheck == true)
            {
                for (int d = 2; d <= Math.Sqrt(primeTest); d++)
                {
                    if (primeTest % d == 0)
                    {
                        primeNumber = false;
                    }
                }
                Console.WriteLine("Is \"{0}\" a prime number: {1}", primeTest, primeNumber);
            }
            else
                Console.WriteLine("Sorry but the number you entered is invalid for the purpose of this application.\nPlease try again with a correct number.");
        }
    }
    }
