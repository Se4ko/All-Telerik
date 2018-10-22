using System;
/*
Problem 4. Fire
*/
class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        // ...##...   1   a = n/2 - RowA    b = #   c = starts from 2nd rowA; d = # e = a
        // ..#..#..   2   . = n / 2 - rowA(2)
        // .#....#.   3   .
        // #......#   4   .
        for (int rowA = 1; rowA <= n / 2; rowA++)
        {
            for (int i = 0; i < n / 2 - rowA; i++) //a
            {
                Console.Write(".");
            }
            Console.Write("#"); //b
            for (int i = 1; i < rowA; i++) //c
            {
                Console.Write("..");
            }
            Console.Write("#"); //d
            for (int i = 0; i < n / 2 - rowA; i++) //e
            {
                Console.Write(".");
            }
            Console.Write("\n");
        }

        // #......#     
        // .#....#.     
        for (int rowB = 1; rowB <= n / 4; rowB++)
        {
            for (int i = 1; i < rowB; i++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int i = 0; i < n - rowB * 2; i++)
            {
                Console.Write(".");
            }
            Console.Write("#");
            for (int i = 1; i < rowB; i++)
            {
                Console.Write(".");
            }
            Console.Write("\n");
        }
        // --------
        for (int i = 0; i < n; i++)
        {
            Console.Write("-");
        }
        Console.Write("\n");

        // \\\\//// 0  . = Row  \ = n / 2    / = n / 2
        // .\\\///. 1  . = Row  \ = n / 2 - row     / = n / 2 - row
        // ..\\//.. 2  . = Row  \ = n / 2 - row     / = n / 2 - row
        // ...\/... 3  . = Row  \ = n / 2 - row     / = n / 2 - row

        for (int RowC = 0; RowC < n / 2; RowC++)
        {
            for (int i = 0; i < RowC; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < n / 2 - RowC; i++)
            {
                Console.Write("\\");
            }
            for (int i = 0; i < n / 2 - RowC; i++)
            {
                Console.Write("/");
            }
            for (int i = 0; i < RowC; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}