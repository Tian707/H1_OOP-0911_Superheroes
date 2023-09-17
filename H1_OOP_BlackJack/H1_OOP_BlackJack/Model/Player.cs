using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{

    //interface IPlayer
    //{
    //    byte UpdateHandScore(Card card);
    //}


    public class Player 
    {

        private byte _handScore = 0;

        public byte HandScore { get => _handScore; private set => _handScore = value; }
        public Player()
        {
            HandScore = 0;
        }
        /// <summary>
        /// Update handScore
        /// determine the value of Ace based on the handScore
        /// </summary>
        /// <param name="card"></param>
        /// <param name="currentHandScore"></param>
        /// <returns></returns>
        public byte UpdateHandScore(Card card)
        {
            if (_handScore <= 10 && card.Rank == 1)
            {
                _handScore += 11;
                //card.FaceValue = 11;
            }
            else if(card.Rank > 10 && card.Rank < 14)
            {
                _handScore += 10;
            }
            else
            {
                _handScore += card.Rank;
            }

            return _handScore;
        }
    }
}
