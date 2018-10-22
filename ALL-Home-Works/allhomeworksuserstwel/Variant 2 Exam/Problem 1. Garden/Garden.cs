using System;
/*
Problem 1. Garden
*/
class Garden
{
    static void Main()
    {
        //Get seeds number and area for tomato, cucumber, potato, carrot, cabbage, beans.
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());
        //Calculate price for all and area status
        int areaNeeded = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
        double seedsCost = tomatoSeeds * 0.5 + cucumberSeeds * 0.4 + potatoSeeds * 0.25 + carrotSeeds * 0.6 + cabbageSeeds * 0.3 + beansSeeds * 0.4;
        int beansArea = 250 - areaNeeded;
        //Print the results
        Console.WriteLine("Total costs: {0:0.00}",seedsCost);
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}",beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
