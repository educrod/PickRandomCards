using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RadomValue() + " of " + RamsomSuit();
            }
            return pickedCards;
        }

        private static string RamsomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RadomValue()
        {
            // get random number from 1 to 14
            int value = random.Next(1, 14);
            // if it's 1 return the string Ace
            if (value == 1) return "Ace";
            // if it's 1 return the string Jack
            if (value == 11) return "Jack";
            // if it's 1 return the string Queen
            if (value == 12) return "Queen";
            // if it's 1 return the string King
            if (value == 13) return "King";
            // if we haven't returned yet, return the number and convert it to string
            return value.ToString();
        }
    }
}
