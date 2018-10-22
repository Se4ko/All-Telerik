using System;
/*
14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/
class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter your decimal number:");
        long userNumber = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        long quotient = 1;
        long calculation = 0;
        while (quotient != 0)
        {
            calculation = userNumber % 2;
            binary += calculation.ToString();
            quotient = userNumber / 2;
            userNumber = quotient;
        }
        char[] binChar = binary.ToCharArray();
        Console.Write("Binary representation: ");
        for (int i = binChar.Length - 1; i >= 0; i--)
        {
            Console.Write(binChar[i]);
        }
    }
}
