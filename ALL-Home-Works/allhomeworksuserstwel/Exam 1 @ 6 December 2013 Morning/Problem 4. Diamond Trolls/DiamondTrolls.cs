using System;
//Problem 4. Diamond Trolls
class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = (6 + ((n - 3) / 2) * 3);

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col == n)
                {
                    Console.Write('*'); // Prints the mid vertical line
                }
                else if (row == height - n - 1)
                {
                    Console.Write('*'); // Prints the mid horizontal line
                }
                else if (col >= n / 2 + 1 && col < width - (n / 2 + 1) && row == 0)
                {
                    Console.Write('*'); // Prints the --- on top
                }
                else if ((row - col == n / 2 + 1) || (row - col == (n / 2 + n) * -1))
                {
                    Console.Write('*'); // Prints the \ lines
                }
                else if ((row + col == n / 2 + 1) || (row + col == (n * 3 - (n / 2))))
                {
                    Console.Write('*'); // Prints the / lines
                }
                else
                {
                    Console.Write('.'); // Prints the rest
                }
            }
            Console.WriteLine(); // Moves the printing to the next row after the current one is finished
        }
    }
}
