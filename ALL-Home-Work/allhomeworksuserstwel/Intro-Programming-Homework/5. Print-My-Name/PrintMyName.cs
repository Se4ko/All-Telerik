using System;
/*
5. Print Your Name

Modify the previous application to print your name.
Ensure you have named the application well (e.g. “PrintMyName”).
*/
class PrintMyName
{
    static void Main()
    {
        Console.WriteLine("Can you tell me your name ?");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is {0}.", name);
    }
}
