using System;
/*
Problem 3. Binary Digits
*/
class BinaryDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int j = 0; j <= 4; j++)
        {
            for (int i = 15; i >= 0; i--)
            {
                int mask = 1 << i;
                int maskResult = n & mask;
                int bit = maskResult >> i;


                if (bit == 0)
                {
                    string zero = "";
                    switch (j)
                    {
                        case 0:
                            zero = "###";
                            break;
                        case 1:
                            zero = "#.#";
                            break;
                        case 2:
                            zero = "#.#";
                            break;
                        case 3:
                            zero = "#.#";
                            break;
                        case 4:
                            zero = "###";
                            break;
                    }
                    Console.Write(zero);
                }
                else if (bit == 1)
                {
                    string one = "";
                    switch (j)
                    {
                        case 0:
                            one = ".#.";
                            break;
                        case 1:
                            one = "##.";
                            break;
                        case 2:
                            one = ".#.";
                            break;
                        case 3:
                            one = ".#.";
                            break;
                        case 4:
                            one = "###";
                            break;
                    }
                    Console.Write(one);
                }
                if (i != 0)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}