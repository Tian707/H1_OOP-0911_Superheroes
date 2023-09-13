using H1_OOP_BlackJack.Control;

namespace H1_OOP_BlackJack
{
    public class Program
    {
        static void Main(string[] args)
        {
           PlayGame game = new PlayGame();
            game.Start();
        }
    }
}