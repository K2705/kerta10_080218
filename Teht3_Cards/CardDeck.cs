using System;
using System.Collections.Generic;

namespace Teht3_Cards
{
    /// <summary>
    /// Represents a deck of cards
    /// TODO: Drawing a single random card? Drawing topmost card?
    /// </summary>
    internal class CardDeck
    {
        public List<PlayingCard> Cards { get; } //Should mebbe be a stack.
        private int highestValue;

        public CardDeck(string[] values, string[] suits)
        {
            Cards = new List<PlayingCard>();
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    Cards.Add(new PlayingCard(values[j] + " of " + suits[i], j + 1));
                }
            }
            highestValue = values.Length + 1;
        }

        public void PrintDeck()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                Console.WriteLine("Card number " + (i + 1) + " is " + Cards[i]);
            }
        }

        public void Shuffle(Random rng)
        {
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                PlayingCard value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

        public void AddSpecialCards(string[] cardNames)
        {
            for (int i = 0; i < cardNames.Length; i++)
            {
                Cards.Add(new PlayingCard(cardNames[i], highestValue));
                highestValue++;
            }
        }
    }
}