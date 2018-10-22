using System;
/*
1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/
class DeclareVariables
{
    static void Main()
    {
        sbyte sbyteTypeVariable = -115;
        byte byteTypeVariable = 97;
        short shortTypeVariable = -10000;
        ushort ushortTypeVariable = 52130;
        int intTypeVariable = 4825932;

        Console.WriteLine("Most appropriate variable types for the given values are:");
        Console.WriteLine("For \t{0}\t sbyte\t is most appropriate.", sbyteTypeVariable);
        Console.WriteLine("For \t{0}\t byte\t is most appropriate.", byteTypeVariable);
        Console.WriteLine("For \t{0}\t short\t is most appropriate.", shortTypeVariable);
        Console.WriteLine("For \t{0}\t ushort\t is most appropriate.", ushortTypeVariable);
        Console.WriteLine("For \t{0}\t int\t is most appropriate.", intTypeVariable);
    }
}
