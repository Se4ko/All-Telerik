using System;
/*
2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/
class GravitationOnTheMoon
{
        static void Main()
        {
        Console.WriteLine("Hello, can you tell me your weight on Earth ?");
        float earthWeight = float.Parse(Console.ReadLine());
        float moonGravity = 0.17f;
        float moonWeight = earthWeight * moonGravity;
        Console.WriteLine("On the surface of the moon you will weigh: {0}", moonWeight);
        }
    }
