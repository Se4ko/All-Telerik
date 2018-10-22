using System;
/*
Problem 5. Smetalnik
*/
class Smetalnik
{
    static void Main()
    {
        int widht = int.Parse(Console.ReadLine());
        long[] line = new long[8];
        for (int i = 0; i < 8; i++)
        {
            line[i] = long.Parse(Console.ReadLine());
        }

        bool working = true;
        long bits = 0;
        while (working)
        {
            string command = Console.ReadLine();
            if (command == "right")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                if (col < 0)
                {
                    col = 0;
                }
                if (col > widht - 1)
                {
                    col = widht - 1;
                }
                long mask = 0;
                for (int i = 0; i < widht - col; i++)
                {
                    mask |= 1L << i;
                }
                bits = line[row] & mask;
                line[row] &= ~mask;
                int bitsCount = 0;
                while (bits > 0)
                {
                    if ((bits & 1) == 1)
                    {
                        bitsCount++;
                    }
                    bits >>= 1;
                }
                long newBits = 0;
                for (int i = 0; i < bitsCount; i++)
                {
                    newBits |= 1L << i;
                }
                line[row] |= newBits;
            }
            else if (command == "left")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                if (col < 0)
                {
                    col = 0;
                }
                if (col > widht - 1)
                {
                    col = widht - 1;
                }
                long mask = 0;
                for (int i = widht - col - 1; i < widht; i++)
                {
                    mask |= 1L << i;
                }
                bits = line[row] & mask;
                line[row] &= ~mask;
                int bitsCount = 0;
                while (bits > 0)
                {
                    if ((bits & 1) == 1)
                    {
                        bitsCount++;
                    }
                    bits >>= 1;
                }
                long newBits = 0;
                for (int i = widht - 1; i >= widht - bitsCount; i--)
                {
                    newBits |= 1L << i;
                }
                line[row] |= newBits;
            }
            else if (command == "reset")
            {
                long mask = 0;
                for (int i = 0; i < widht; i++)
                {
                    mask |= 1L << i;
                }
                bits = line[0] & mask;
                for (int i = 0; i < 8; i++)
                {
                    line[i] &= ~mask;
                }

                int bitsCount = 0;
                while (bits > 0)
                {
                    if ((bits & 1) == 1)
                    {
                        bitsCount++;
                    }
                    bits >>= 1;
                }
                long newBits = 0;
                for (int i = widht - 1; i >= widht - bitsCount; i--)
                {
                    newBits |= 1L << i;
                }
                for (int i = 0; i < 8; i++)
                {
                    line[i] |= newBits;
                }

            }
            else
            {
                working = false;
            }
        }
        long sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += line[i];
        }
        long colSum = 0;
        for (int i = 0; i < 8; i++)
        {
            colSum |= line[i];
        }
        int zeroColCount = 0;
        for (int i = 0; i < widht; i++)
        {
            if ((colSum & 1 << i) == 0)
            {
                zeroColCount++;
            }
        }
        Console.WriteLine(sum * zeroColCount);
    }
}
