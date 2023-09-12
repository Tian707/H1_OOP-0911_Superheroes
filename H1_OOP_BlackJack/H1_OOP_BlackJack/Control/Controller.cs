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
            do
            {
                _display.ClearWindow();
                _display.GameIntro(_game.artTitle, _game.gameTitle, _game.description);

                // InitializeGame, Initialize cadr list
                // dealing 2 cards to both player and dealer and update scores
                _game.InitializeGame();

            }
            while (_game._player._score < 21 && )
        }


    }
}
