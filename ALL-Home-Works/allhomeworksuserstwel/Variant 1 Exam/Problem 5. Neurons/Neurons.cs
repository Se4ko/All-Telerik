using System;
using System.Collections.Generic;
/*
Problem 5. Neurons
*/
class Neurons
{
    static void Main()
    {
        //get the numbers
        bool inputEnabler = true;
        List<Int64> numbers = new List<Int64>();
        while (inputEnabler)
        {
            Int64 input = Int64.Parse(Console.ReadLine());
            if (input == -1)
            {
                inputEnabler = false;
            }
            else
            {
                numbers.Add(input);
            }
        }
        //Calculating the results and storing them
        List<string> results = new List<string>();
        string[] numbersArray = new string[numbers.Count];
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = ~numbers[i];
            numbersArray[i] = Convert.ToString(numbers[i], 2);
            int strLStart = numbersArray[i].Length;
            numbersArray[i] = numbersArray[i].TrimEnd('1');
            int strLEnd = strLStart - numbersArray[i].Length;
            numbersArray[i] = numbersArray[i].TrimStart('1');
            strLStart = numbersArray[i].Length;
            numbersArray[i] = numbersArray[i].TrimEnd('0');
            int strMEnd = strLStart - numbersArray[i].Length;
            strLEnd += strMEnd;
            numbersArray[i] = numbersArray[i].TrimStart('0');
            results.Add(numbersArray[i]);
            if (results[i] == "")
            {
                results[i] = "0";
            }
            else
            {
                for (int j = 0; j < strLEnd; j++)
                {
                    results[i] += "0";
                }

            }
        }
        //Print the results
        foreach (String item in results)
        {
            Int64 tempNumber = Convert.ToInt64(item, 2);
            Console.WriteLine(tempNumber);
        }
    }
}