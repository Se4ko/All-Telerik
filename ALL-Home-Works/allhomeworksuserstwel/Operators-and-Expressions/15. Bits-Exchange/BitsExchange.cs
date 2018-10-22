using System;
/*
15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/
class BitsExchange
{
    static void Main()
    {
        Console.Write("Your Number from 0 to 4294967295 : ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of n");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        uint maskOne = 7 << 3;
        uint maskTwo = 7 << 24;
        uint extractOne = number & maskOne;
        uint extractTwo = number & maskTwo;
        number = number & (~extractOne);
        number = number & (~extractTwo);
        extractOne = extractOne << 21;
        extractTwo = extractTwo >> 21;
        uint extractSum = extractOne | extractTwo;
        number = number | extractSum;
        Console.WriteLine("Binary result");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
