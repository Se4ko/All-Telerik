using System;
/*
13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary integer:");
        string binary = Console.ReadLine();
        char[] binChar = binary.ToCharArray();
        long power = binChar.Length - 1;
        long decimalForm = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            decimalForm += long.Parse(binChar[i].ToString()) * (long)Math.Pow(2, power);
            power--;
        }
        Console.WriteLine("Decimal: {0}", decimalForm);

    }
}
