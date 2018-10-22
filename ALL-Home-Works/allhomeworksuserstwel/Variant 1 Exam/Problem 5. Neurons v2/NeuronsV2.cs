using System;
using System.Collections.Generic;
/*
Problem 5. Neurons
*/
class NeuronsSecondVersion
{
    static void Main()
    {
        List<long> results = new List<long>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "-1")
            {
                for (int j = 0; j < results.Count; j++)
                {
                    Console.WriteLine(results[j]);
                }
                break;
            }
            long inputNumber = long.Parse(input);
            if (inputNumber == 0)
            {
                results.Add(inputNumber);
                continue;
            }
            int mostRightBorder = -1;
            int mostLeftBorder = -1;
            for (int p = 0; p < 32; p++)
            {
                long mask = 1 << p;
                long numberAndMask = inputNumber & mask;
                long bit = numberAndMask >> p;

                if (bit == 1)
                {
                    if (mostRightBorder == -1)
                    {
                        mostRightBorder = p;
                    }
                    mostLeftBorder = p;
                }
            }
            long result = 0;
            for (int p = mostRightBorder; p <= mostLeftBorder; p++)
            {
                long mask = 1 << p;
                long numberAndMask = inputNumber & mask;
                long bit = numberAndMask >> p;
                if (bit == 0)
                {
                    result = result | mask;
                }
            }
            results.Add(result);
        }
    }
}