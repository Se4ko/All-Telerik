using System;
/*
16. Decimal to Hexadecimal Number


Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/
class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Enter your number in decimal format:");
        long userNumber = long.Parse(Console.ReadLine());
        string converted = "";
        long result = userNumber;
        bool zCheck = true;
        while (zCheck == true)
        {
            long remainder = result % 16;
            result = result / 16;
            converted += remainder.ToString();
            if (result > 0)
            {
                converted += " ";
            }
            else
            {
                zCheck = false;
            }
        }
        string[] convToArray = converted.Split(' ');
        for (int i = 0; i < convToArray.Length; i++)
        {
            switch (convToArray[i])
            {
                case "10":
                    convToArray[i] = "A";
                    break;
                case "11":
                    convToArray[i] = "B";
                    break;
                case "12":
                    convToArray[i] = "C";
                    break;
                case "13":
                    convToArray[i] = "D";
                    break;
                case "14":
                    convToArray[i] = "E";
                    break;
                case "15":
                    convToArray[i] = "F";
                    break;
                default:
                    break;
            }
        }
        string answer = "";
        for (int i = convToArray.Length - 1; i >= 0; i--)
        {
            answer += convToArray[i];
        }
        Console.WriteLine("The HEX representation of {0} is: {1}", userNumber, answer);
    }
}
