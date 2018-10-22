using System;
/*
11. Bitwise: Extract Bit

Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/
class BitWiseExtractBitThree
{
    static void Main()
    {
        int position = 3;
        Console.WriteLine("Please input a number.");
        uint number = uint.Parse(Console.ReadLine());
        int mask = 1 << position;
        int result = (int)number & mask;
        int bit = result >> position;
        Console.WriteLine("Bit number 3 is: {0}",bit);

    }
}
