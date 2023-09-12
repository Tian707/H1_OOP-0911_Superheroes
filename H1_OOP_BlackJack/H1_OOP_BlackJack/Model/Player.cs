using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    internal class Player
    {
        // List for cards in hand to calculate score
        private List<Card> _hand { get; }
        private byte _score;

        public Player()
        {
            _hand = new List<Card>();
            _score = 0; 
        }

        public byte AddScore(Card card)
        {
            byte handScore;
            bool success = Byte.TryParse(card.ToString(), out handScore);
            if (!success)
            {
                throw new ArgumentOutOfRangeException("Invalid card rank.");
            }
            else
            {
                _score += handScore;
            }
            return _score;
        }
    }
}
