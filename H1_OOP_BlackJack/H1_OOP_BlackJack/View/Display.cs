using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.View
{
    public class Display
    {
        public void Bye()
        {
            Console.WriteLine("Thank you for playing. See you next time.");
        }
        public void HitOrStand()
        {
            Console.WriteLine("Do you want to hit or stand?");
        }

        public void PlayNewRound()
        {
            Console.WriteLine("Do you want to paly again? Y/N");
        }

        public void BlackJack(string player)
        {
            Console.WriteLine($"{player} had Black Jack!");
        }
        public void Bust(string player)
        {
            Console.WriteLine($"{player} Bust! Lose!");
        }
        public void Win(string player)
        {
            Console.WriteLine($"{player} Wins!");
        }
        public void Tie()
        {
            Console.WriteLine("It's a tie!");
        }
        public void DisplayFirstCards(byte playerFirstCard, byte dealerFirstCard)
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
