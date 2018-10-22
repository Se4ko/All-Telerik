using System;
using System.Numerics;
/*
Problem 3. Card Wars
*/
class CardWars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger playerOneScore = 0;
        BigInteger playerTwoScore = 0;
        int playerOneGamesWon = 0;
        int playerTwoGamesWon = 0;
        bool xPower = false;
        for (int i = 0; i < n; i++)
        {
            int playerOneHand = 0;
            int playerTwoHand = 0;
            int eventXOne = 0;
            int eventXTwo = 0;
            for (int j = 0; j < 6; j++)
            {
                string card = Console.ReadLine().ToUpper();
                int cardValue = 0;
                #region CardSwitch
                switch (card)
                {
                    case "2":
                        cardValue = 10;
                        break;
                    case "3":
                        cardValue = 9;
                        break;
                    case "4":
                        cardValue = 8;
                        break;
                    case "5":
                        cardValue = 7;
                        break;
                    case "6":
                        cardValue = 6;
                        break;
                    case "7":
                        cardValue = 5;
                        break;
                    case "8":
                        cardValue = 4;
                        break;
                    case "9":
                        cardValue = 3;
                        break;
                    case "10":
                        cardValue = 2;
                        break;
                    case "A":
                        cardValue = 1;
                        break;
                    case "J":
                        cardValue = 11;
                        break;
                    case "Q":
                        cardValue = 12;
                        break;
                    case "K":
                        cardValue = 13;
                        break;
                    case "Z":
                        if (j < 3)
                        {
                            playerOneScore *= 2;
                        }
                        else
                        {
                            playerTwoScore *= 2;
                        }
                        break;
                    case "Y":
                        if (j < 3)
                        {
                            playerOneScore -= 200;
                        }
                        else
                        {
                            playerTwoScore -= 200;
                        }
                        break;
                    case "X":
                        if (j < 3)
                        {
                            eventXOne++;
                        }
                        else
                        {
                            eventXTwo++;
                        }
                        break;
                }
                #endregion
                if (j < 3)
                {
                    playerOneHand += cardValue;
                }
                else
                {
                    playerTwoHand += cardValue;
                }
            }
            if (eventXOne > 0 && eventXTwo > 0)
            {
                playerOneScore += 50;
                playerTwoScore += 50;
            }
            else if (eventXOne > 0 && eventXTwo == 0)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                xPower = true;
                break;
            }
            else if (eventXTwo > 0 && eventXOne == 0)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                xPower = true;
                break;
            }
            if (playerOneHand > playerTwoHand)
            {
                playerOneScore += playerOneHand;
                playerOneGamesWon++;
            }
            else if (playerTwoHand > playerOneHand)
            {
                playerTwoScore += playerTwoHand;
                playerTwoGamesWon++;
            }
        }
        if (playerOneScore > playerTwoScore && xPower == false)
        {
            Console.WriteLine("First player wins!\nScore: {0}\nGames won: {1}", playerOneScore, playerOneGamesWon);
        }
        else if (playerTwoScore > playerOneScore && xPower == false)
        {
            Console.WriteLine("Second player wins!\nScore: {0}\nGames won: {1}", playerTwoScore, playerTwoGamesWon);
        }
        else if (playerOneScore == playerTwoScore && xPower == false)
        {
            Console.WriteLine("It's a tie!\nScore: {0}", playerOneScore);
        }
    }
}