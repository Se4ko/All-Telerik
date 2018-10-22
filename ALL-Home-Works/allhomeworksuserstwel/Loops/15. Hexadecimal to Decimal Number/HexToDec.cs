using System;
/*
15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/
class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Enter HEX for conversion");
        string hexString = Console.ReadLine().ToUpper();
        char[] hexCharArray = hexString.ToCharArray();
        string[] hexStringArray = new string[hexCharArray.Length];
        for (int i = 0; i < hexCharArray.Length; i++)
        {
            switch (hexCharArray[i])
            {
                case 'A':
                    hexStringArray[i] = "10";
                    break;
                case 'B':
                    hexStringArray[i] = "11";
                    break;
                case 'C':
                    hexStringArray[i] = "12";
                    break;
                case 'D':
                    hexStringArray[i] = "13";
                    break;
                case 'E':
                    hexStringArray[i] = "14";
                    break;
                case 'F':
                    hexStringArray[i] = "15";
                    break;
                default:
                    hexStringArray[i] = hexCharArray[i].ToString();
                    break;
            }
        }
        long ConvertedHex = 0;
        for (int k = 0, j = hexCharArray.Length - 1; k < hexCharArray.Length && j >= 0; k++, j--)
        {
            long calculation = Convert.ToInt64(hexStringArray[k]) * (long)Math.Pow(16, j);
            ConvertedHex += calculation;

        }
        Console.WriteLine("The decimal represantation of HEX : {0} is : {1}", hexString, ConvertedHex);
    }
}
