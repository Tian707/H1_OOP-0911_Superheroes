using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    public struct Card
    {
        // using a private field here
        // can access to its value through constructor below, no need to setter for now
        private int _rank;

        /// <summary>
        /// constructor than can access rank valule 
        /// </summary>
        /// <param name="rank"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Card(int rank)
        {
            if (rank < 2 || rank > 14)
            {
                throw new ArgumentOutOfRangeException("Invalid card rank.");
            }

            _rank = rank;
        }
        /// <summary>
        ///  Override ToString to display the card's value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string rankString;

            if (_rank >= 11 && _rank <= 13) // Jack, Queen, King
            {
                rankString = "10"; // They are all worth 10 points
            }
            else if (_rank == 14) // Ace
            {
                rankString = "11"; // Aces are worth 11 by default
            }
            else
            {
                rankString = _rank.ToString(); // Numeric cards
            }

            return rankString;
        }
    }
}
