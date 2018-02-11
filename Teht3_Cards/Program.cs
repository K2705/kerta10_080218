using System;

namespace Teht3_Cards
{
    class Program
    {
        private static Random RNG = new Random();


        /// <summary>
        /// Mess around with virtual card decks
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            CardDeck cards = new CardDeck(values, suits);

            TestDeck(cards);

            Console.ReadKey();
            Console.WriteLine();

            string[] tarotValues = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Page", "Knight", "Queen", "King" };
            string[] tarotSuits = { "Cups", "Pentacles", "Wands", "Swords" };
            string[] trumps = { "The Fool", "The Magician", "The High Priestess", "The Empress", "The Emperor", "The Hierophant", "The Lovers",
                "The Chariot", "Strength", "The Hermit", "Wheel of Fortune", "Justice", "The Hanged Man", "Death", "Temperance", "The Devil",
                "The Tower", "The Star", "The Moon", "The Sun", "Judgment", "The World" };

            CardDeck tarotCards = new CardDeck(tarotValues, tarotSuits);
            tarotCards.AddSpecialCards(trumps);

            TestDeck(tarotCards);

        }

        

        private static void TestDeck(CardDeck cards)
        {
            cards.PrintDeck();
            Console.ReadKey();
            Console.WriteLine("Shuffling deck...");
            cards.Shuffle(RNG);
            cards.PrintDeck();
        }
        
    }
}
