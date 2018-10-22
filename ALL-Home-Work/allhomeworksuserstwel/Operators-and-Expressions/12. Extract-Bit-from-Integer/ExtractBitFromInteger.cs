using System;
/*
12. Extract Bit from Integer

Write an expression that extracts from given integer n the value of given bit at index p.
*/
class ExtractBitFromInteger
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
        Console.WriteLine("The bit at position {0} for the number {1} has a value of {2}.", position, number, bit);
    }
}
