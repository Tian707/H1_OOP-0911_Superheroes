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
    internal class Deck
    {
        private List<Card> _cards; // List to hold the cards
        private int _currentIndex; // Index to track the current card being dealt
        private Random random; // Random number for dealing a card
        

        /// <summary>
        /// Here creates an Deck object with the initial 13 cards and a random number to deal a card
        /// </summary>
        public Deck()
        {
            InitializeDeck();
            random = new Random();
        }

        public void InitializeDeck()
        {
            // Create a list to hold 13 cards (2 to 14)
            _cards = new List<Card>();

            for (int rank = 2; rank <= 14; rank++)
            {
                _cards.Add(new Card(rank));
                
            }
        }
        /// <summary>
        /// Deal random cards to players then delete them from the array
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Card DealCard()
        {
            if (_cards.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }

            int randomIndex = random.Next(0, _cards.Count);
            Card dealtCard = _cards[randomIndex];
            _cards.RemoveAt(randomIndex); // Remove the card from the list.
            return dealtCard;
        }
        public List<Card> GetDeck()
        {
            return _cards; // Return the entire deck as a List<Card>
        }
}
}
