using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    public class Dealer : Player
    {
        // Declare an instance of Player and Dealer respectively
        private Deck _deck;
        //private byte _dealerHandScore = 0;

        public Deck Deck { get => _deck; private set => _deck = value; }

       // public byte DealerHandScore { get => _dealerHandScore; private set => _dealerHandScore = value; }



        /// <summary>
        /// constructor for a Dealer object, when new a Dealer, 
        /// initialize the instances of Deck, get a list of cards
        /// shuffle it and return a list of shuffled cards, _deck.Cards
        /// </summary>
        public Dealer()
        {
            _deck = new Deck();
            _deck.ShuffleDeck();
        }
        
        /// <summary>
        /// Each time dealing a card, we take the first card on top of the Deck,
        /// remove the handed card from the deck 
        /// </summary>
        /// <returns></returns>
        public Card DealingProcess()
        {
            Card handedCard = _deck.Cards.First();
            _deck.DeleteHandedCard(handedCard);
            return handedCard;
        }

        
    }
}
