using System;
using System.Collections.Generic;
using System.Threading;
/*
12.** Falling Rocks

Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/

struct GameObject 
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}

class FallingRocks
{
    static void printOnPosition (int x, int y, string str, ConsoleColor color = ConsoleColor.DarkBlue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;
        int playFieldWidth = 40;
        int spaceLives = 7;
        int timeSinceStart = Environment.TickCount;
        int score;
        double scoreMultipler = 0;
        int away = 0;

        GameObject ship = new GameObject();
        ship.x = 17;
        ship.y = Console.WindowHeight - 1;
        ship.str = "(O)";
        ship.color = ConsoleColor.Cyan;
        Random randomGenerator = new Random();
        List<GameObject> spaceObjects = new List<GameObject>();

        while (true)
        {
            bool collision = false;
            int randomColor = randomGenerator.Next(0, 7);
            int randomSymbol = randomGenerator.Next(0, 13);
            var asteroidColor = ConsoleColor.Yellow;
            if (randomColor == 0)
            {
                asteroidColor = ConsoleColor.Blue;
            }
            else if (randomColor == 1)
            {
                asteroidColor = ConsoleColor.Red;
            }
            else if (randomColor == 2)
            {
                asteroidColor = ConsoleColor.Magenta;
            }
            else if (randomColor == 3)
            {
                asteroidColor = ConsoleColor.White;
            }
            else if (randomColor == 4)
            {
                asteroidColor = ConsoleColor.Green;
            }
            else
            {

            }

            var asteroidChar = "^";
            if (randomSymbol == 0)
            {
                asteroidChar = "@";
            }
            else if (randomSymbol == 1)
            {
                asteroidChar = "*";
            }
            else if (randomSymbol == 2)
            {
                asteroidChar = "&";
            }
            else if (randomSymbol == 3)
            {
                asteroidChar = "+";
            }
            else if (randomSymbol == 4)
            {
                asteroidChar = "%";
            }
            else if (randomSymbol == 5)
            {
                asteroidChar = "$";
            }
            else if (randomSymbol == 6)
            {
                asteroidChar = "#";
            }
            else if (randomSymbol == 7)
            {
                asteroidChar = "!";
            }
            else if (randomSymbol == 8)
            {
                asteroidChar = ".";
            }
            else if (randomSymbol == 9)
            {
                asteroidChar = ";";
            }
            else if (randomSymbol == 10)
            {
                asteroidChar = "-";
            }
            else
            {
                
            }

            if ( away == 0)
            {
                score = 0;
            }
            else
            {
                score = ((timeSinceStart / 10000) * (int)scoreMultipler );
            }
            

            GameObject asteroid = new GameObject();
            asteroid.x = randomGenerator.Next(0, playFieldWidth);
            asteroid.y = 0;
            asteroid.color = asteroidColor;
            asteroid.str = asteroidChar;
            spaceObjects.Add(asteroid);
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (ship.x - 1 >= 0)
                    {
                        ship.x = ship.x - 1;
                        away++;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (ship.x + 1 < (playFieldWidth-2))
                    {
                        ship.x = ship.x + 1;
                        away++;
                    }
                }
            }
            List < GameObject > newList = new List<GameObject>();
            for (int i = 0; i < spaceObjects.Count; i++)
            {
                GameObject oldComet = spaceObjects[i];
                GameObject newComet = new GameObject();
                newComet.x = oldComet.x;
                newComet.y = oldComet.y + 1;
                newComet.str = oldComet.str;
                newComet.color = oldComet.color;
                if (newComet.x == ship.x && newComet.y == ship.y || newComet.x == ship.x+1 && newComet.y == ship.y || newComet.x == ship.x+2 && newComet.y == ship.y)
                {
                    spaceLives--;
                    collision = true;
                    if (spaceLives <= 0)
                    {
                        Console.Beep();
                        printOnPosition(45, 10, "Lives:" + spaceLives, ConsoleColor.Green);
                        printOnPosition(43, 12, "GAME OVER!!!", ConsoleColor.DarkMagenta);
                        printOnPosition(43, 14, "Score: " + score, ConsoleColor.DarkMagenta);
                        printOnPosition(43, 15, "Press any key", ConsoleColor.DarkMagenta);
                        printOnPosition(43, 16, "to exit.", ConsoleColor.DarkMagenta);
                        Console.ReadKey();
                        return;
                    }
                }
                if (newComet.y < Console.WindowHeight)
                {
                    newList.Add(newComet);
                    scoreMultipler += 0.01;
                }
            }
            spaceObjects = newList;
            Console.Clear();
            if (collision)
            {
                spaceObjects.Clear();
                printOnPosition(ship.x, ship.y, "XXX", ConsoleColor.Red);
            }
            else
            {
                printOnPosition(ship.x, ship.y, ship.str, ship.color);
            }
            foreach (GameObject comet in spaceObjects)
            {
                printOnPosition(comet.x, comet.y, comet.str, comet.color);
            }
            printOnPosition(42, 3, "Use <- and -> to", ConsoleColor.Gray);
            printOnPosition(42, 4, "move and avoid", ConsoleColor.Gray);
            printOnPosition(42, 5, "getting hit.", ConsoleColor.Gray);
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(playFieldWidth, i);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("|");
            }
            printOnPosition(45, 10, "Lives:" + spaceLives, ConsoleColor.Green);
            Thread.Sleep(150);
        }
    }
}
