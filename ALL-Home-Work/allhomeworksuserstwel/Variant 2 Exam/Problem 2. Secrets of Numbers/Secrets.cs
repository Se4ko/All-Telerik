using System;
using System.Numerics;
/*
Problem 2. Secrets of Numbers
*/
class Secrets
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        //Special Sum
        int inputLength = inputStr.Length;
        BigInteger input = BigInteger.Parse(inputStr);
        if (input < 0)
        {
            input *= -1;
        }
        BigInteger specialSum = 0;
        for (int i = 1; i <= inputLength; i++)
        {
            BigInteger currentDigit = input % 10;
            if (i % 2 != 0)
            {
                specialSum += currentDigit * (BigInteger)Math.Pow(i, 2);
            }
            else
            {
                specialSum += (BigInteger)(currentDigit * currentDigit) * i;
            }
            input /= 10;
        }
        //Sequence Length
        BigInteger sequenceLength = specialSum % 10;
        //Sequence
        BigInteger r = specialSum % 26;
        string alphaSequence = "";
        if (sequenceLength > 0)
        {
            int tempPosition = (int)r;
            for (int j = 0; j < sequenceLength; j++)
            {
                string tempLetter = "";
                tempPosition ++;
                if (tempPosition > 26)
                {
                    tempPosition = 1;
                }
                #region Alphabet 
                switch (tempPosition)
                {
                    case 1:
                        tempLetter = "A";
                        break;
                    case 2:
                        tempLetter = "B";
                        break;
                    case 3:
                        tempLetter = "C";
                        break;
                    case 4:
                        tempLetter = "D";
                        break;
                    case 5:
                        tempLetter = "E";
                        break;
                    case 6:
                        tempLetter = "F";
                        break;
                    case 7:
                        tempLetter = "G";
                        break;
                    case 8:
                        tempLetter = "H";
                        break;
                    case 9:
                        tempLetter = "I";
                        break;
                    case 10:
                        tempLetter = "J";
                        break;
                    case 11:
                        tempLetter = "K";
                        break;
                    case 12:
                        tempLetter = "L";
                        break;
                    case 13:
                        tempLetter = "M";
                        break;
                    case 14:
                        tempLetter = "N";
                        break;
                    case 15:
                        tempLetter = "O";
                        break;
                    case 16:
                        tempLetter = "P";
                        break;
                    case 17:
                        tempLetter = "Q";
                        break;
                    case 18:
                        tempLetter = "R";
                        break;
                    case 19:
                        tempLetter = "S";
                        break;
                    case 20:
                        tempLetter = "T";
                        break;
                    case 21:
                        tempLetter = "U";
                        break;
                    case 22:
                        tempLetter = "V";
                        break;
                    case 23:
                        tempLetter = "W";
                        break;
                    case 24:
                        tempLetter = "X";
                        break;
                    case 25:
                        tempLetter = "Y";
                        break;
                    case 26:
                        tempLetter = "Z";
                        break;
                    default:
                        break;
                }
                #endregion
                alphaSequence += tempLetter;
            }
            //Print results
            Console.WriteLine(specialSum);
            Console.WriteLine(alphaSequence);
        }
        else
        {
            Console.WriteLine(specialSum);
            Console.WriteLine("{0} has no secret alpha-sequence",inputStr);
        }
    }
}
