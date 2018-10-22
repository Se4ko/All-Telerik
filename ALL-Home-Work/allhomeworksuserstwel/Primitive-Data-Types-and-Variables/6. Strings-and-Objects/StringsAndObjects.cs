using System;
/*
6. Strings and Objects

Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/
class StringsAndObjects
{
    static void Main()
    {
        string stringOne = "Hello";
        string stringTwo = "World";
        object stringOneAndTwo = stringOne + " " + stringTwo;
        string stringThree = (string)stringOneAndTwo; //We can also get the same result with stringOneAndTwo.ToString()
        Console.WriteLine(stringThree);
    }
}
