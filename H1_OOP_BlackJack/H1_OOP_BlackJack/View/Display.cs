using H1_OOP_BlackJack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.View
{
    public class Display
    {
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
        public static void DisplayFirstCards(byte playerCard1, byte dealerCard1)
        {
            Console.WriteLine("Dealing two cards to the player...");
            Console.WriteLine($"Player's first card value is {playerCard1} points.\n");
            Console.WriteLine("Dealing two cards to the dealer...");
            Console.WriteLine($"Dealer's first card value is {dealerCard1} points.\n");
        }
        public static void DisplayPlayerInfo(Card card, byte currentScore)
        {
            Console.WriteLine("Dealing card to the player...");
            Console.WriteLine($"Your card is {card}.");
            Console.WriteLine($"Your current point is: {currentScore}.\n");
        }
        /// <summary>
        /// Hit ot Stand with input validation, only returns hit or stand
        /// </summary>
        public static string HitOrStand()
        {
            bool continueAsk = true;
            string choice = "";
            while (continueAsk)
            {   
                Console.WriteLine("Do you want to hit or stand?");
                choice = Console.ReadLine().ToLower();
                if(choice == "hit" || choice == "stand")
                {
                    continueAsk = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter hit or stand:\n");
                }
            }
            return choice;
        }

        /// <summary>
        /// Control new round or exit
        /// with user input validation
        /// </summary>
        public static void PlayNewRound()
        { 
            while (true)
            {
                //Ask Play New Round
                Console.WriteLine("Do you want to paly again? Y/N");
                ConsoleKey keyPressed = Console.ReadKey().Key;

                if (keyPressed == ConsoleKey.Y)
                {
                    // Break out of the inner loop to start a new round
                    break;
                }
                else if (keyPressed == ConsoleKey.N)
                {
                    Console.WriteLine("Thank you for playing. \nPress any key to exit. See you next time.");
                    Console.ReadKey();
                    // Exit the method or function
                    Environment.Exit(0);
                }
                else
                {
                    Display.Print("Invalid input. Please try again.");
                }
            }
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
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
