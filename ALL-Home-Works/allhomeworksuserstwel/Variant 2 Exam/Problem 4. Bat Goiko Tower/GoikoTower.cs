using System;
using System.Collections.Generic;
/*
Problem 4. Bat Goiko Tower
*/
class GoikoTower
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int n = 0;
        List<int> beams = new List<int>();
        for (int i = 0; i < h; i++)
        {
            n = i + n;
            beams.Add(n);
        }
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h - (i + 1); j++)
            {
                Console.Write(".");
            }
            Console.Write("/");
            for (int l = 0; l < i; l++)
            {

                if (beams.Contains(i) && i != 0)
                {
                    Console.Write("--");
                }
                else
                {
                    Console.Write("..");
                }
            }
            Console.Write("\\");
            for (int j = 0; j < h - (i + 1); j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}