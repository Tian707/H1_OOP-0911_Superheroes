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
        // can access to its value through constructor below, no need to set for now
        private readonly byte _rank;
        //private byte _faceValue = 0;
        private readonly byte _suit;


        public readonly byte Rank { get => _rank;  }
        public readonly byte Suit { get => _suit;   }
        //public byte FaceValue
        //{
        //    get
        //    {
        //        // Calculate face value based on rank
        //        if (_rank >= 1 && _rank <= 10)
        //        {
        //            return _rank;
        //        }
        //        else if (_rank >= 11 && _rank <= 13)
        //        {
        //            return 10; // Jack, Queen, and King have face value of 10
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException(nameof(_rank), "Invalid card rank. Must be be.");
        //        }
        //    }
        //    set // possibility to set the FaceValue for Ace, depending on HandValue
        //    {
        //        if(_rank == 1)
        //        {
        //            _faceValue = value;
        //        }
        //    }
        //}

        /// <summary>
        /// When generate a card in Deck, pass in rank and suit, 
        /// Face value is based on its rank
        /// But when rank = 1 (Ace), face value depends on the handValue
        /// So I will set face value as 1, then make a condition to check when play game
        /// when rank =1, if handValue <= 10, set face value to 11
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suit"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Card(byte rank, byte suit)
        {
            if (rank < 1 || rank > 13)
            {
                throw new ArgumentOutOfRangeException(nameof(rank), "Invalid card rank. Must be between 1 and 13.");
            }
            _rank = rank;
            _suit = suit;

        }

        /// <summary>
        ///  Override ToString to display the card's value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Rank: {Rank}, Suits: {Suit}";
        }

    }
}
