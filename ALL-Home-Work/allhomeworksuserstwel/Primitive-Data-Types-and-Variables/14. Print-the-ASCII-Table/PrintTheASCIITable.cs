using System;
using System.Text;
/*
14.* Print the ASCII Table

Find online more information about ASCII (American Standard Code for Information Interchange) and write a program
that prints the entire ASCII table of characters on the console (characters from 0 to 255).
*/
class PrintTheASCIITable
{
    static void Main()
    {
       for (int a = 0; a <= 255; a++)
       {
           char c = (char)a;
           Console.WriteLine("{0} is {1}",a,c);
            
       }
    }
}
