using System;
/*
13. Check a Bit at Given Position

Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
in given integer number n, has value of 1.
*/
class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Input number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Input position:");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;
        bool bitAtPosition = bit == 1;
        Console.WriteLine("The bit at position {0} in the number {1} has value of 1: {2}" ,position ,number ,bitAtPosition);
    }
}
