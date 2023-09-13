using H1_OOP_BlackJack.Model;
using H1_OOP_BlackJack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Control
{
    internal class Controller
    {
        //attributes:
        private Game _game;
        private Display _display;

        /// <summary>
        /// A constructor that automatically creates and initializes<br/>
        /// instance of the Game and the Display class when <br/>
        /// a Controller object is created. 
        /// </summary>
        public Controller()
        {
            _display = new Display();
            _game = new Game();
        }

        public void Start()
        {
            byte playerValue1, playerScore, dealerValue1, dealerScore;

            // reaching close to 21:
            do
            {

                _display.ClearWindow();
                _display.GameIntro(_game.artTitle, _game.gameTitle, _game.description);

                // InitializeGame, Initialize card list
                // dealing 2 cards to both player and dealer, update their scores

                (playerValue1, playerScore, dealerValue1, dealerScore) = _game.InitializeGame();
                // show value of first cards
                _display.DisplayFirstCards(playerValue1, dealerValue1);

                _display.HitOrStand();
                string choice = Console.ReadLine();


            }
            while (playerScore < 21 && dealerScore < 21);

            // blackJack:
            if (playerScore == 21)
            {
                _display.BlackJack("Player");
            }
            else if (dealerScore == 21)
            {
                _display.BlackJack("Dealer");
            }

            // Bust:
            else if (playerScore > 21)
            {
                _display.Bust("Player");
            }
            else if (dealerScore > 21)
            {
                _display.Bust("Dealer");
            }


            // win or lose
            else if (playerScore > dealerScore)
            {
                _display.Bust("Player");
            }
            else if (dealerScore > playerScore)
            {
                _display.Bust("Dealer");
            }
            // tie
            else if (dealerScore == playerScore)
            {
                _display.Tie();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Unkonwn error");
            }

            //Ask Play New Round
            _display.PlayNewRound();
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Y)
            {
                Start();
            }
            else if (keyPressed.Key == ConsoleKey.N)
            {
                _display.Bye();
            }
            else { throw new ArgumentOutOfRangeException("Invalid input. Please try again."); }

        }
    }
}
