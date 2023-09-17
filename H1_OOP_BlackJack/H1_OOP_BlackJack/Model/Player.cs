using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    public class Player
    {

        private byte _HandScore = 0;

        public byte HandScore { get => _HandScore; private set => _HandScore = value; }
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
        public byte UpdateHandScore(Card card, byte currentHandScore)
        {
            if (currentHandScore <= 10 && card.Rank == 1)
            {
                card.FaceValue = 11;
            }

            return currentHandScore += card.FaceValue;
        }
    }
}
