namespace H1_OOP_RemoteControlledCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RCCController controller = new RCCController(System.Drawing.Color.Blue);
            controller.Start();
            
        }
    }
}