using ThePlanets.Control;
using ThePlanets.Model;


namespace ThePlanets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller ctrl = new Controller();
            ctrl.Start();
        }
    }
}