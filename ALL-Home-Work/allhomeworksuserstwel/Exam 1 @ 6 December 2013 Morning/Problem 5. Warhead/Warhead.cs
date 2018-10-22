using System;
//Problem 5. Warhead
class Warhead
{
    static void Main()
    {
        string[,] matrix = new string[16, 16];
        for (int row = 0; row < 16; row++)
        {
            string inputLine = Console.ReadLine();
            int col = 0;
            foreach (char c in inputLine)
            {
                matrix[row, col] = c.ToString();
                col++;
            }
        }
        bool bombAlive = true;
        int exit = 0;
        int unsafeWireClusters = 0;
        while (bombAlive)
        {
            string command = Console.ReadLine();
            int row = 0;
            int col = 0;
            #region Cut
            if (command == "cut")
            {
                string wire = Console.ReadLine();
                if (wire == "red" || wire == "left")
                {
                    int clusters = 0;
                    for (int rowRed = 1; rowRed < 15; rowRed++)//To check all posible coordinates
                    {
                        for (int colRed = 1; colRed < 8; colRed++)//To check all posible coordinates !!!ColRed!!!
                        {
                            int capacitors = 0;
                            int r = rowRed - 1;
                            int c = colRed - 1;
                            for (int k = r; k < r + 3; k++)//To check around the given coordinates
                            {
                                for (int j = c; j < c + 3; j++)//To check around the given coordinates
                                {
                                    if (matrix[k, j] == "1")
                                    {
                                        capacitors++;
                                    }
                                }
                            }
                            if (matrix[rowRed, colRed] == "0" && capacitors == 8)
                            {
                                clusters++;
                            }
                        }
                    }
                    if (clusters == 0)
                    {
                        exit = 2;//Red is safe
                        bombAlive = false;
                    }
                    else if (clusters != 0)
                    {
                        exit = 3;// Red is not safe
                        unsafeWireClusters = clusters;
                        bombAlive = false;
                    }
                }
                else if (wire == "blue" || wire == "right")
                {
                    int clusters = 0;
                    for (int rowBlue = 1; rowBlue < 15; rowBlue++)//To check all posible coordinates
                    {
                        for (int colBlue = 8; colBlue < 15; colBlue++)//To check all posible coordinates !!!ColBlue!!!
                        {
                            int capacitors = 0;
                            int r = rowBlue - 1;
                            int c = colBlue - 1;
                            for (int k = r; k < r + 3; k++)//To check around the given coordinates
                            {
                                for (int j = c; j < c + 3; j++)//To check around the given coordinates
                                {
                                    if (matrix[k, j] == "1")
                                    {
                                        capacitors++;
                                    }
                                }
                            }
                            if (capacitors == 8)
                            {
                                if (matrix[rowBlue, colBlue] == "0" && capacitors == 8)
                                {
                                    clusters++;
                                }
                            }
                        }
                    }
                    if (clusters == 0)
                    {
                        exit = 4;//Blue is safe
                        bombAlive = false;
                    }
                    else if (clusters != 0)
                    {
                        exit = 5;// Blue is not safe
                        unsafeWireClusters = clusters;
                        bombAlive = false;
                    }
                }
            }
            #endregion
            else if (command != "cut")
            {
                row = int.Parse(Console.ReadLine());
                col = int.Parse(Console.ReadLine());
                #region Hover
                if (command == "hover")
                {
                    if (matrix[row, col] == "1")
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                #endregion
                #region Operate
                if (command == "operate")
                {
                    if (matrix[row, col] == "1")
                    {
                        exit = 1;
                        bombAlive = false;
                    }
                    else if (col != 0 && col != 15 && row != 0 && row != 15)
                    {
                        int r = row - 1;
                        int c = col - 1;
                        int capacitors = 0;
                        for (int k = r; k < r + 3; k++)
                        {
                            for (int j = c; j < c + 3; j++)
                            {
                                if (matrix[k, j] == "1")
                                {
                                    capacitors++;
                                }
                            }
                        }
                        if (capacitors == 8)
                        {
                            for (int k = r; k < r + 3; k++)
                            {
                                for (int j = c; j < c + 3; j++)
                                {
                                    if (matrix[k, j] == "1")
                                    {
                                        matrix[k, j] = "0";
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            #region Testing
            //Random rr = new Random();
            //int nr = rr.Next(1, 4);
            //switch (nr)
            //{
            //    case 1:
            //        Console.ForegroundColor = ConsoleColor.DarkBlue;
            //        break;
            //    case 2:
            //        Console.ForegroundColor = ConsoleColor.Cyan;
            //        break;
            //    case 3:
            //        Console.ForegroundColor = ConsoleColor.DarkGreen;
            //        break;
            //    case 4:
            //        Console.ForegroundColor = ConsoleColor.DarkRed;
            //        break;
            //}
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < 16; i++)
            //{
            //    for (int j = 0; j < 16; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor();
            #endregion
        }
        #region Exits
        if (exit == 1)//Touched a capacitor while using Operate
        {
            int clusters = 0;
            for (int row = 1; row < 15; row++)//To check all posible coordinates
            {
                for (int col = 1; col < 15; col++)//To check all posible coordinates
                {
                    int capacitors = 0;
                    int r = row - 1;
                    int c = col - 1;
                    for (int k = r; k < r + 3; k++)//To check around the given coordinates
                    {
                        for (int j = c; j < c + 3; j++)//To check around the given coordinates
                        {
                            if (matrix[k, j] == "1")
                            {
                                capacitors++;
                            }
                        }
                    }
                    if (capacitors == 8)
                    {
                        clusters++;
                    }
                }
            }
            Console.WriteLine("missed");
            Console.WriteLine(clusters);
            Console.WriteLine("BOOM");
        }
        else if (exit == 2)//Red is safe
        {
            int clusters = 0;
            for (int rowBlue = 1; rowBlue < 15; rowBlue++)//To check all posible coordinates
            {
                for (int colBlue = 8; colBlue < 15; colBlue++)//To check all posible coordinates
                {
                    int capacitors = 0;
                    int r = rowBlue - 1;
                    int c = colBlue - 1;
                    for (int k = r; k < r + 3; k++)//To check around the given coordinates
                    {
                        for (int j = c; j < c + 3; j++)//To check around the given coordinates
                        {
                            if (matrix[k, j] == "1")
                            {
                                capacitors++;
                            }
                        }
                    }
                    if (capacitors == 8)
                    {
                        clusters++;
                    }
                }
            }
            Console.WriteLine(clusters);
            Console.WriteLine("disarmed");
        }
        else if (exit == 3)//Red is not safe
        {
            Console.WriteLine(unsafeWireClusters);
            Console.WriteLine("BOOM");
        }
        else if (exit == 4)//Blue is safe
        {
            int clusters = 0;
            for (int rowRed = 1; rowRed < 15; rowRed++)//To check all posible coordinates
            {
                for (int colRed = 1; colRed < 8; colRed++)//To check all posible coordinates
                {
                    int capacitors = 0;
                    int r = rowRed - 1;
                    int c = colRed - 1;
                    for (int k = r; k < r + 3; k++)//To check around the given coordinates
                    {
                        for (int j = c; j < c + 3; j++)//To check around the given coordinates
                        {
                            if (matrix[k, j] == "1")
                            {
                                capacitors++;
                            }
                        }
                    }
                    if (capacitors == 8)
                    {
                        clusters++;
                    }
                }
            }
            Console.WriteLine(clusters);
            Console.WriteLine("disarmed");
        }
        else if (exit == 5)//Blue is not safe
        {
            Console.WriteLine(unsafeWireClusters);
            Console.WriteLine("BOOM");
        }
        #endregion
    }
}