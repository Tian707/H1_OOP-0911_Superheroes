using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_BlackJack.Model
{
    /// <summary>
    /// Initialization of a new game
    /// </summary>
    public class Game
    {
        // Attibutes
        public string artTitle = @" _______   ___            __       ______   __   ___           ___      __       ______   __   ___  
|   _  ""\ |""  |          /""""\     /"" _  ""\ |/""| /  "")         |""  |    /""""\     /"" _  ""\ |/""| /  "") 
(. |_)  :)||  |         /    \   (: ( \___)(: |/   /          ||  |   /    \   (: ( \___)(: |/   /  
|:     \/ |:  |        /' /\  \   \/ \     |    __/           |:  |  /' /\  \   \/ \     |    __/   
(|  _  \\  \  |___    //  __'  \  //  \ _  (// _  \        ___|  /  //  __'  \  //  \ _  (// _  \   
|: |_)  :)( \_|:  \  /   /  \\  \(:   _) \ |: | \  \      /  :|_/ )/   /  \\  \(:   _) \ |: | \  \  
(_______/  \_______)(___/    \___)\_______)(__|  \__)    (_______/(___/    \___)\_______)(__|  \__) 
                                                                                                    
";
        public string gameTitle = "Black Jack";
        public string description = "Welcome to Blackjack! Your goal is to get as close to 21 as possible without going over. \nHere's how:\n\n1. Card Values:\nNumber cards (2 to 10) are worth their face value.\nFace cards (Jack, Queen, King) are 10 points.\nAces can be 1 or 11 points, this is random.\n\n2. Gameplay:\nYou can 'Hit' for another card or 'Stand' with your current hand.\nGet 21 without busting (going over 21) to win instantly.\n\n3. Winning:\nBeat the dealer's hand without busting.\nA tie is a 'Push.'\nNow, go for 21 and have fun in Blackjack!";

        // the instance of Deck, Player and Dealer
        private Deck _deck;
        private Player _player;
        private Player _dealer;


        /// <summary>
        /// A constructor that automatically creates and initializes<br/>
        /// instance of the Player, Dealer and Deck class when <br/>
        /// a Game object is created. 
        /// </summary>
        public Game()
        {
            _deck = new Deck();
            _player = new Player();
            _dealer = new Player();
            
        }
        public (byte, byte,byte,byte) InitializeGame()
        {
            Card playerCard1 = _deck.DealCard();
            byte playerScore = _player.AddScore(playerCard1);
            Card playerCard2 = _deck.DealCard();
            playerScore = _player.AddScore(playerCard2);

            Card dealerCard1 = _deck.DealCard();
            byte dealerScore = _player.AddScore(dealerCard1);
            Card dealerCard2 = _deck.DealCard();
            dealerScore = _player.AddScore(dealerCard1);
            return 
        }
        public byte GetPlayerScore()
        {
            //get updated playerscore
            return _player.AddScore(_deck.DealCard());
        }
        public byte GetDealererScore()
        {
            //get updated playerscore
            return _player.AddScore(_deck.DealCard());
        }


    }
}
