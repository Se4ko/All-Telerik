using System;
/*
9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/
class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n\nInt --> 1\nDouble --> 2\nString --> 3\n");
        int decision = int.Parse(Console.ReadLine());
        switch (decision)
        {
            case 1:
                Console.WriteLine("Please enter a integer:");
                int intValue = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}",intValue + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double doubleValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", doubleValue + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string stringValue = Console.ReadLine();
                Console.WriteLine("Result: {0}", stringValue + "*");
                break;
            default:
                Console.WriteLine("Invalid choice input.");
                break;
        }

    }
}
