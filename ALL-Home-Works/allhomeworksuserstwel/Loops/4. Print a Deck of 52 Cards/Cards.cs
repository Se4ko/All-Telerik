using System;
/*
4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
The cards should be printed using the classical 
notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
Use 2 nested for-loops and a switch-case statement.
*/
class Cards
{
    static void Main()
    {
        string[] cards = new string[13];
        cards[0] = "2";
        cards[1] = "3";
        cards[2] = "4";
        cards[3] = "5";
        cards[4] = "6";
        cards[5] = "7";
        cards[6] = "8";
        cards[7] = "9";
        cards[8] = "10";
        cards[9] = "J";
        cards[10] = "Q";
        cards[11] = "K";
        cards[12] = "A";

        string[] suit = new string[4];
        suit[0] = "clubs";
        suit[1] = "diamonds";
        suit[2] = "hearts";
        suit[3] = "spades";

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < suit.Length; j++)
            {
                Console.Write("{0} of {1}", cards[i], suit[j]);
                switch (j)
                {
                    case 3:
                        Console.Write("\n");
                        break;
                    default:
                        Console.Write(", ");
                        break;
                }
            }
        }
    }
}
