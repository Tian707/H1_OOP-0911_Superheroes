using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_RemoteControlledCars
{
    public class RCCView
    {
        public void ShowMenu()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("D - Drive");
            Console.WriteLine("B - Break");
            Console.WriteLine("R - Reset");
            Console.WriteLine("Q - Quit");
        }
        public void ShowInvalidInput()
        {
            Console.WriteLine("Invalid input. Please choose a valid option.");
        }
        public void DrivingNow(Color carColor)
        {
            Console.WriteLine($"Your {carColor} car is driving now.");
        }
        public void ShowInfo(int distance, byte batteryLeft)
        {
            //Console.WriteLine($"Car color: {carColor}");
            Console.WriteLine($"Distance: {distance} meter");
            Console.WriteLine($"Battery Left: {batteryLeft}%");
        }
        public void RemindToRecharge(int distance, byte batteryLeft)
        {
            Console.WriteLine($"Distance: {distance} meter");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Only {batteryLeft}% battery left, please recharge soon.");
            Console.ResetColor();
        }
        public void AskForRecharge(int distance)
        {
            Console.WriteLine($"Distance: {distance} meter");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The battery is empty.");
            Console.ResetColor();
            Console.WriteLine("Do you want to recharge and reset the car now? (Y/N)");
            
        }
        public void ResetView()
        {
            Console.Clear();
        }



    }
}
 