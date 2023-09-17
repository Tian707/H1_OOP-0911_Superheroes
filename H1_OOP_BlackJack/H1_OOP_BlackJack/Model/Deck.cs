using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    /// <summary>
    /// Define a class to represent a deck of cards
    /// </summary>
    public class Deck
    {
        private List<Card> _cards; // List to hold the cards
        
        /// <summary>
        /// property Cards, to get the value from _cards
        /// can access through _deck.Cards
        /// </summary>
        public List<Card> Cards { get => _cards; private set => _cards = value; }

        /// <summary>
        /// Here creates an Deck object with the initial cards, 13 of each suit
        /// </summary>
        public Deck()
        {
            _cards = InitializeDeck();
        }

        public List<Card> InitializeDeck()
        {
                // Create a list to hold 13 * 4 cards (1 to 13)
                _cards = new List<Card>();

                for (byte i = 1; i < 5; i++)
                {
                    for (byte j = 1; j < 14; j++)
                    {
                        Card card = new Card(j, i);
                        _cards.Add(card);
                    }
                }
            return _cards;
        }


        /// <summary>
        /// Check Deck count > 0. 
        /// Shuffle deck using the Fisher-Yates shuffle algorithm, 
        /// then we can just take the first card in the deck for each dealing
        /// </summary>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public List<Card>  ShuffleDeck()
        {
            Random random = new Random();
            int count = _cards.Count;

            if (count < 1)
            {
                throw new IndexOutOfRangeException ("The deck is empty.");
            }
            // iterate from the last card in the list
            for(int i = count - 1; i >= 0; i--)
            {
                // index for a random card to swap with the we are iterating now
                int j = random.Next(0, i + 1);

                // get a random card, save it as a temporary card
                Card temp = _cards[j];

                // swap it with card i
                _cards[j] = _cards[i];
                _cards[i] = temp;
            }
            return _cards;
        }
        /// <summary>
        /// Remove a handed card from the deck
        /// </summary>
        /// <param name="HandedCard"></param>
        public void DeleteHandedCard(Card HandedCard)
        {
            _cards.Remove(HandedCard);
        }
        
    }
}
