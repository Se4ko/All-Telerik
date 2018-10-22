using System;
/*
16.* Print Long Sequence

Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
*/
class PrintLongSequence
{
    static void Main()
    {
        for (int s = 2; s <= 1001; s++)
        {
            if (s % 2 == 0)
            {
                Console.Write(s);
                if (s<=1000)
                {
                    Console.Write(",");
                }
            }
             else
            {
                Console.Write("-{0}", s);
                if (s<=1000)
                {
                    Console.Write(",");
                }
            }       
        }
    }
}
