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
    internal class PlayGame
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
        private const string description = "Welcome to Blackjack! Your goal is to get as close to 21 as possible without going over. \nHere's how:\n\n1. Card Values:\nNumber cards (2 to 10) are worth their face value.\nFace cards (Jack, Queen, King) are 10 points.\nAces can be 1 or 11 points, this is random.\n\n2. Gameplay:\nYou can 'Hit' for another card or 'Stand' with your current hand.\nGet 21 without busting (going over 21) to win instantly.\n\n3. Winning:\nBeat the dealer's hand without busting.\nA tie is a 'Push.'\nNow, go for 21 and have fun in Blackjack!";

        // Declare an instance of Player and Dealer respectively
        private Player _player;
        private Dealer _dealer;

        /// <summary>
        /// constructor for a PlayGame object, when new a PlayGame, 
        /// initialize the instances og Deck, Player and Dealer in current game
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

                do
                {

                    //Dealing playerHand1
                    //Dealing playerHand2
                    //Dealing dealerHand1
                    //Dealing dealerHand2
                    //display playerHand1, dealerHand1

                    //display playerHand2 for player

                    // if one's Hand1 value=10, hand2 is Ace, score = 21, BlackJack
                    // if not, update dealerScore and playerScore
                    // display playerScore for player

                    bool continueAsk = true;
                    while (continueAsk)
                    {
                        Display.HitOrStand();
                        string choice = Console.ReadLine().ToLower();
                        switch (choice)
                        {
                            case "hit":
                                {
                                    // New card to player, update playerScore, show player
                                    // New card to dealer, update dealerScore
                                    continueAsk = false;
                                    break;
                                }
                            case "stand":
                                {
                                    // New card to dealer, Update dealerScore
                                    continueAsk = false;
                                    break;
                                }
                            default:
                                {
                                    throw new ArgumentOutOfRangeException("Invalid input. Please choose 'hit' or 'stand'");
                                    // Continue the loop to ask for input again
                                }
                        }
                    }
                }
                while (playerScore < 21 && dealerScore < 21);

                try
                {
                    // Result Control:
                    // blackJack:
                    if (playerScore == 21)
                    {
                        Display.BlackJack("Player");
                    }
                    else if (dealerScore == 21)
                    {
                        Display.BlackJack("Dealer");
                    }

                    // Bust:
                    else if (playerScore > 21)
                    {
                        Display.Bust("Player");
                    }
                    else if (dealerScore > 21)
                    {
                        Display.Bust("Dealer");
                    }

                    // win or lose
                    else if (playerScore > dealerScore)
                    {
                        Display.Bust("Player");
                    }
                    else if (dealerScore > playerScore)
                    {
                        Display.Bust("Dealer");
                    }
                    // tie
                    else if (dealerScore == playerScore)
                    {
                        Display.Tie();
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentOutOfRangeException("Unknown error");
                }


                //Control NewRound or Exit
                while (true)
                {
                    //Ask Play New Round
                    Display.PlayNewRound();
                    ConsoleKey keyPressed = Console.ReadKey().Key;

                    if (keyPressed == ConsoleKey.Y)
                    {
                        // Break out of the inner loop to start a new round
                        break;
                    }
                    else if (keyPressed == ConsoleKey.N)
                    {
                        Display.Bye();
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
        }
    }
}
