using System;
/*
14. Modify a Bit at Given Position

We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from 
the binary representation of n while preserving all other bits in n.
*/
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Input your number.");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Input bit value 1 or 0.");
        int v = int.Parse(Console.ReadLine());
        bool vCheck = v == 0 || v == 1;
        if (vCheck == !true)
        {
            Console.WriteLine("V must be 1 or 0");
            return;
        }
        Console.WriteLine("Input position.");
        int p = int.Parse(Console.ReadLine());
        if (v == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("Binari result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + result);
        }
        else
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("Binari result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + result);
        }
    }
}
