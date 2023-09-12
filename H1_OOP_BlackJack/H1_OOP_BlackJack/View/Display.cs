using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.View
{
    public class Display
    {

        public void DisplayDealingTwoCards(byte playerFirstCard, byte dealerFirstCard)
        {
            Console.WriteLine("Dealing two cards to the player...");
            Console.WriteLine($"Player's first card value is {playerFirstCard}.");
            Console.WriteLine("Dealing two cards to the dealer...");
            Console.WriteLine($"Dealer's first card value is {dealerFirstCard}.");
        }

        public void GameIntro(string artTitle, string gameTitle, string description)
        {
            Console.Clear();
            Console.WriteLine(artTitle);
            Console.WriteLine(gameTitle);
            Console.WriteLine(description);
        }
        public void ClearWindow()
        {
            Console.Clear();
        }
    }
}
