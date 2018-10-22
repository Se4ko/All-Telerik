using System;
/*
Problem 4. Eggcelent
*/
class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int drawingArea = (3 * n) + 1;
        int eggHeight = 2 * n;

        for (int r = 0; r < eggHeight; r++)
        {
            for (int c = 0; c < drawingArea; c++)
            {
                if ((c > n && c < 2 * n) && (r == 0 || r == eggHeight - 1))
                {
                    Console.Write("*");
                }
                else if ((r >= n / 2 && r < 2 * n - n / 2) && (c == 1 || c == drawingArea - 2))
                {
                    Console.Write("*");
                }
                else if ((2 * r - c == -(2 * n - 1)) || (2 * r - c == 3 * n - 3))
                {
                    Console.Write("*");
                }
                else if ((2 * r + c == n + 1) || (2 * r + c == 6 * n - 3))
                {
                    Console.Write("*");
                }
                else if ((r == n - 1 || r == n) && (c > 1 && c < drawingArea - 2) && ((r + c) % 2 == 1))
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
