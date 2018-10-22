using System;
/*
9. Print a Sequence

Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/
class PrintASequence
{
    static void Main()
    {
        for (int I = 2; I <= 11; I++)
        {
            if (I % 2 == 0)
            {
                Console.Write(I);
                if (I <= 10)
                {
                    Console.Write(",");
                }
            }
            else
            {
                Console.Write("-{0}",I);
                if (I<=10)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
