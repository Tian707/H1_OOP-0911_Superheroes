using H1_OOP_BlackJack.Model;
using H1_OOP_BlackJack.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H1_OOP_BlackJack.Control
{
    /// <summary>
    /// Here starts a new game, initialize new deck, player and dealer
    /// </summary>
    public class PlayGame
    {
        //Attributes
        private const string artTitle = @" _______   ___            __       ______   __   ___           ___      __       ______   __   ___  
|   _  ""\ |""  |          /""""\     /"" _  ""\ |/""| /  "")         |""  |    /""""\     /"" _  ""\ |/""| /  "") 
(. |_)  :)||  |         /    \   (: ( \___)(: |/   /          ||  |   /    \   (: ( \___)(: |/   /  
|:     \/ |:  |        /' /\  \   \/ \     |    __/           |:  |  /' /\  \   \/ \     |    __/   
(|  _  \\  \  |___    //  __'  \  //  \ _  (// _  \        ___|  /  //  __'  \  //  \ _  (// _  \   
|: |_)  :)( \_|:  \  /   /  \\  \(:   _) \ |: | \  \      /  :|_/ )/   /  \\  \(:   _) \ |: | \  \  
(_______/  \_______)(___/    \___)\_______)(__|  \__)    (_______/(___/    \___)\_______)(__|  \__) 
                                                                                                    
";
        private const string gameTitle = "Black Jack";
        private const string description = "Welcome to Blackjack! Your goal is to get as close to 21 as possible without going over. \nHere's how:\n\n1. Card Values:\nNumber cards (2 to 10) are worth their face value.\nFace cards (Jack, Queen, King) are 10 points.\nAces will be 11 point if your current points is less than 11.\n\n2. Gameplay:\nYou can 'Hit' for another card or 'Stand' with your current hand.\nGet 21 without busting (going over 21) to win instantly.\n\n3. Winning:\nBeat the dealer's hand without busting.\nA tie is a 'Push.'\nNow, go for 21 and have fun in Blackjack!\n\n";

        // Declare an instance of Player and Dealer respectively
        private Player _player;
        private Dealer _dealer;

        /// <summary>
        /// constructor for a PlayGame object, when new a PlayGame, 
        /// initialize the instances of a shuffled Deck, a Player and a Dealer in current game
        /// </summary>
        public PlayGame()
        {
            _player = new Player();
            _dealer = new Dealer();
        }


        public void Start()
        {
            while (true)
            {
                // Start a new game
                Display.ClearWindow();
                Display.GameIntro(artTitle, gameTitle, description);
                byte playerHandValue;
                byte dealerHandValue;

                Card playerCard1 = _dealer.DealingProcess();
                Card playerCard2 = _dealer.DealingProcess();
                playerHandValue = _player.UpdateHandScore(playerCard1, _player.HandScore);

                Card dealerCard1 = _dealer.DealingProcess();
                Card dealerCard2 = _dealer.DealingProcess();
                dealerHandValue = _dealer.UpdateHandScore(dealerCard1, _dealer.HandScore);

                //Show player first cads info
                Display.DisplayFirstCards(playerHandValue, dealerHandValue);

                // Update player and dealer handValue after 2 cards
                playerHandValue = _player.UpdateHandScore(playerCard2, playerHandValue);
                dealerHandValue = _dealer.UpdateHandScore(dealerCard2, dealerHandValue);

                // Display player info:
                Display.DisplayPlayerInfo(playerCard2, playerHandValue);

                do
                {
                    // Ask player Hit or Stand
                    string choice = Display.HitOrStand();
                    switch (choice)
                    {
                        case "hit":
                            {
                                // New card to player, update playerScore, show player
                                Card playerCard3 = _dealer.DealingProcess();
                                // Update player handValue
                                playerHandValue = _player.UpdateHandScore(playerCard3, playerHandValue);
                                // Display player info:
                                Display.DisplayPlayerInfo(playerCard3, playerHandValue);

                                // New card to dealer, update dealerScore
                                Card dealerCard3 = _dealer.DealingProcess();
                                dealerHandValue = _dealer.UpdateHandScore(dealerCard3, dealerHandValue);
                                break;
                            }
                        case "stand":
                            {
                                // New card to dealer, Update dealerScore
                                Card dealerCard4 = _dealer.DealingProcess();
                                dealerHandValue = _dealer.UpdateHandScore(dealerCard4, dealerHandValue);
                                break;
                            }
                    }

                }
                while (playerHandValue < 21 && dealerHandValue < 21);

                try
                {
                    // Result Control:
                    // blackJack:
                    if (playerHandValue == 21)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.BlackJack("Player");
                    }
                    else if (dealerHandValue == 21)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.BlackJack("Dealer");
                    }

                    // Bust:
                    else if (playerHandValue > 21)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.Bust("Player");
                    }
                    else if (dealerHandValue > 21)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.Bust("Dealer");
                    }

                    // win or lose
                    else if (playerHandValue < dealerHandValue)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.Print("You lose!");
                    }
                    else if (dealerHandValue > playerHandValue)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.Print("You win!");
                    }
                    // tie
                    else if (playerHandValue == dealerHandValue)
                    {
                        Display.Print($"Your points: {playerHandValue}, dealer score: {dealerHandValue}");
                        Display.Tie();
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentOutOfRangeException("Unknown error");
                }


                //Control NewRound or Exit
                Display.PlayNewRound();
            }
        }
       
    }
}
