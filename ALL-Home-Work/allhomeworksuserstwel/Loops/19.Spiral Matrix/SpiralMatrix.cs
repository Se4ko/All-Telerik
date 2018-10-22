using System;
/*
19.** Spiral Matrix


Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples.
*/
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 20)
        {
            Console.WriteLine("N must be a number from 1 to 20");
            Console.Write("N:");
            n = int.Parse(Console.ReadLine());
        }
        int[,] matrix = new int[n, n];
        int posY = 0;
        int posX = 0;
        int stepLimit = n;
        int steps = 1;
        int dicretion = 0; //Right default
        int limitChanger = 0;
        for (int i = 1; i <= n * n; i++)
        {
            matrix[posY, posX] = i;
            if (steps < stepLimit)
            {
                steps++;
            }
            else
            {
                steps = 1;
                dicretion = (dicretion + 1) % 4;
                limitChanger++;
                if (limitChanger % 2 == 0)
                {

                }
                else
                {
                    stepLimit--;
                }
            }
            switch (dicretion)
            {
                case 0://right
                    posX++;
                    break;
                case 1://down
                    posY++;
                    break;
                case 2://left
                    posX--;
                    break;
                case 3://up
                    posY--;
                    break;
            }
        }
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,4}", matrix[j, l]);
            }
            Console.WriteLine("\n");
        }
    }
}
