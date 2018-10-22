using System;
using System.IO;
/*
Problem 5. Bittris
// tnx to https://github.com/flextry/Telerik-Academy/blob/master/Programming%20with%20C%23/0.%20Exams/Telerik%202013-2014%20-%20C%23%20Exam%201%20-%20Spring/Telerik%20Academy%20Exam%201%20@%2024%20June%202013/Solutions/5.%20Bittris%20(from%20workshop).cs#L157 
*/
class Bittris
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fieldLine0 = 0;
        int fieldLine1 = 0;
        int fieldLine2 = 0;
        int fieldLine3 = 0;
        int score = 0;
        bool gameOver = false;
        int loops = n / 4;
        while (loops > 0 && !gameOver)
        {
            loops -= 1;

            int number = int.Parse(Console.ReadLine());
            string commandLine = Console.ReadLine().ToUpper() +
                                 Console.ReadLine().ToUpper() +
                                 Console.ReadLine().ToUpper();
            int numberOfBits = Convert.ToString(number, 2)
                                      .Replace("0", "")
                                      .Length;
            number &= 255;
            for (int fieldLineNumber = 0; fieldLineNumber <= 3; fieldLineNumber++)
            {
                if (fieldLineNumber < 3)
                {
                    char command = commandLine[fieldLineNumber];
                    if (command == 'L')
                    {
                        if ((number & (1 << 7)) == 0)
                        {
                            number <<= 1;
                        }
                    }
                    else if (command == 'R')
                    {
                        if ((number & 1) == 0)
                        {
                            number >>= 1;
                        }
                    }
                }


                int thisLine = 0;
                int nextLine = 0;
                switch (fieldLineNumber)
                {
                    case 0:
                        thisLine = fieldLine0; nextLine = fieldLine1;
                        break;
                    case 1:
                        thisLine = fieldLine1; nextLine = fieldLine2;
                        break;
                    case 2:
                        thisLine = fieldLine2; nextLine = fieldLine3;
                        break;
                    case 3:
                        thisLine = fieldLine3;
                        break;
                }

                if ((nextLine & number) != 0 || fieldLineNumber == 3)
                {
                    if ((thisLine | number) == 255)
                    {
                        score += numberOfBits * 10;

                        switch (fieldLineNumber)
                        {
                            case 0:
                                fieldLine0 = 0;
                                break;
                            case 1:
                                fieldLine1 = fieldLine0;
                                break;
                            case 2:
                                fieldLine2 = fieldLine1;
                                fieldLine1 = fieldLine0;
                                break;
                            case 3:
                                fieldLine3 = fieldLine2;
                                fieldLine2 = fieldLine1;
                                fieldLine1 = fieldLine0;
                                break;
                        }
                    }
                    else
                    {
                        switch (fieldLineNumber)
                        {
                            case 0:
                                fieldLine0 |= number;
                                break;
                            case 1:
                                fieldLine1 |= number;
                                break;
                            case 2:
                                fieldLine2 |= number;
                                break;
                            case 3:
                                fieldLine3 |= number;
                                break;
                        }
                        score += numberOfBits;
                    }
                    break;
                }
                if (fieldLine0 != 0)
                {
                    gameOver = true;
                    break;
                }
            }

            if (gameOver == true)
            {
                break;
            }
        }
        Console.WriteLine(score);
    }
}
