using System;
/*
7. Quotes in Strings

Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.
*/
class QuotesInStrings
{
    static void Main()
    {
        string quotationOne = "The \"use\" of quotations causes difficulties.";
        string quotationTwo = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("The printable end result is the same for both of the variables\n{0}\n{1}",quotationOne, quotationTwo);
    }
}
