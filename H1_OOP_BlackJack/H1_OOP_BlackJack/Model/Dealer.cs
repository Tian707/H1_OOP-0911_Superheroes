using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    internal class Dealer
    {
        // Declare an instance of Player and Dealer respectively
        private Deck _deck;


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

        public Cards DealPlayer()
        {

        }
        public Cards DealDealer()
        {

        }

    }
}
