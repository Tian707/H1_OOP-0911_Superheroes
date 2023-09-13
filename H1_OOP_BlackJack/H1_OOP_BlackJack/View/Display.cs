using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.View
{
    public class Display
    {
        public static void Bye()
        {
            Console.WriteLine("Thank you for playing. \nPress any key to exit. See you next time.");
        }
        
        
        public static void HitOrStand()
        {
            Console.WriteLine("Do you want to hit or stand?");
        }

        public static void PlayNewRound()
        {
            Console.WriteLine("Do you want to paly again? Y/N");
        }

        public static void BlackJack(string player)
        {
            Console.WriteLine($"{player} had Black Jack!");
        }
        public static void Bust(string player)
        {
            Console.WriteLine($"{player} Bust! Lose!");
        }
        public void Win(string player)
        {
            Console.WriteLine($"{player} Wins!");
        }
        public static void Tie()
        {
            Console.WriteLine("It's a tie!");
        }
        public static void DisplayFirstCards(byte playerValue1, byte dealerValue1)
        {
            Console.WriteLine("Dealing two cards to the player...");
            Console.WriteLine($"Player's first card value is {playerValue1}.");
            Console.WriteLine("Dealing two cards to the dealer...");
            Console.WriteLine($"Dealer's first card value is {dealerValue1}.");
        }

        public static void GameIntro(string artTitle, string gameTitle, string description)
        {
            Console.Clear();
            Console.WriteLine(artTitle);
            Console.WriteLine(gameTitle);
            Console.WriteLine(description);
        }
        public static void ClearWindow()
        {
            Console.Clear();
        }
    }
}
