using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1_OOP_RemoteControlledCars.Model;

namespace H1_OOP_RemoteControlledCars
{
    public class RCCController
    {
        private RemoteControlledCar _car; // Field to hold the remote-controlled car instance
        private RCCView _view; // Field to hold the view instance

        /// <summary>
        /// A constructor that automatically creates and initializes<br/>
        /// an instance of the RemoteControlledCar and the RCCView class when <br/>
        /// a RCCController object is created. 
        /// </summary>
        public RCCController(Color carColor)
        {
            _car = new RemoteControlledCar(); // Initialize the remote-controlled car
            _view = new RCCView(); // Initialize the view
        }
        public void Start()
        {

            while (true)
            {
                bool isDriving = false;

                // used attribute _battery as public in class RemoteControlled Car
                // check how to get and set an object inside another class
                _view.ShowInfo(_car.Distance, _car._battery.BatteryLeft);

                // Display the menu options
                _view.ShowMenu();

                // Get user input
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D:
                        {
                            if (!isDriving && _car._battery.BatteryLeft > 0)
                            {
                                _car.Drive();
                                // Set isDriving to true when starting to drive
                                isDriving = true;

                                _view.DrivingNow(_car.Color);
                            }
                            break;
                        }
                    case ConsoleKey.B:
                        {
                            if (isDriving)
                            {
                                _car.Breaking();
                                isDriving = false;

                                if (_car._battery.BatteryLeft > 0 && _car._battery.BatteryLeft < 20)
                                {
                                    _view.RemindToRecharge(_car.Distance, _car._battery.BatteryLeft);
                                }
                                else if (_car._battery.BatteryLeft > 20)
                                {
                                    _view.ShowInfo(_car.Distance, _car._battery.BatteryLeft);
                                }
                                if (_car._battery.BatteryLeft == 0)
                                {
                                    _view.AskForRecharge(_car.Distance);

                                    //Get user input
                                    char resetChoice = Console.ReadKey().KeyChar;
                                    if (resetChoice == 'Y' || resetChoice == 'y')
                                    {
                                        _car.ResetCar();
                                        isDriving = false;
                                        _view.ResetView();
                                    }
                                }
                            }
                            break;
                        }
                    case ConsoleKey.R:
                        {
                            _car.ResetCar();
                            isDriving = false;
                            _view.ResetView();
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            return;
                        }
                    default:
                        {
                             // Display invalid input message
                             _view.ShowInvalidInput();
                             break;
                        }

                }
            }
        }
    }
}

